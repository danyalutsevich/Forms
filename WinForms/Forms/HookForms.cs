using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinForms.Forms
{

    public partial class HookForms : Form
    {
        #region DLL Import

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, EntryPoint = "SetWindowsHookEx")]
        private static extern IntPtr SetHook(int idHook, HookProc lpfnProc, IntPtr hMod, uint dwThreadID);

        // All imports are extern static
        // SetWindowsHookEx - Proc name to change proc name add EntryPoint = "YOUR NAME"
        // "user32.dll" - dll name
        // parameter types converted to .NET types

        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool Unhook(IntPtr hHook);

        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr NextHook(IntPtr hHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle", SetLastError = true)]
        public static extern IntPtr GetModule(string lpModuleName);


        //Create system messages and send them to the system
        [DllImport("user32.dll", EntryPoint = "SendInput", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SendMessages(uint uInputs, INPUT[] pInputs, int Size);

        #endregion

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYBOARD_LL = 13;

        private const int WM_MOUSE_LL = 14;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_MOUSEMOVE = 0x200;
        private Bitmap bitmap;

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);


        public HookForms()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.Image = bitmap;
            pictureBox1.InitialImage = bitmap;
        }

        #region KeyboardHook

        private HookProc kbHookPinned;
        private IntPtr hKBHook;
        private GCHandle kbGCHandle;
        
        private IntPtr KBHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                //int keyVirtualCode = Marshal.ReadInt32(lParam);
                KBDLLHOOKSTRUCT hookStruct = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
                int keyVirtualCode = hookStruct.vkCode;
                Keys key = (Keys)keyVirtualCode;

                // Key replace Demo
                foreach (KeyValuePair<Keys, Keys> kvp in listBoxReplaces.Items)
                {
                    if (key == kvp.Key) // key to change
                    {
                        // new system message
                        INPUT input = new INPUT();

                        input.Type = 1; // Keyboard event
                        input.Data.Keyboard.Vk = (ushort)kvp.Value;
                        input.Data.Keyboard.Scan = 0;
                        input.Data.Keyboard.Flags = 0; // 0 - Key down 2 - Key up
                        input.Data.Keyboard.Time = 0;
                        input.Data.Keyboard.ExtraInfo = IntPtr.Zero;

                        INPUT[] inputs = new INPUT[] { input };

                        SendMessages(1, inputs, Marshal.SizeOf(input));


                        //delete old system message
                        richTextBoxKB.Text += $"{kvp.Key} -> {kvp.Value}";
                        return (IntPtr)1;

                    }
                }

                richTextBoxKB.Text += key.ToString();

                if (key == Keys.LWin)
                {
                    richTextBoxKB.Text += "(rejected)";
                    return (IntPtr)1;
                }

            }
            return NextHook(hKBHook, nCode, wParam, lParam);
        }
        
        private void buttonStartKB_Click(object sender, EventArgs e)
        {
            if ((bool)tabPageKeyboard.Tag == true)
            {

                using (Process? currentProcess = Process.GetCurrentProcess())
                {
                    using (ProcessModule? currentModule = currentProcess.MainModule)
                    {
                        kbHookPinned = KBHookProc;
                        kbGCHandle = GCHandle.Alloc(kbHookPinned);

                        if (currentModule == null)
                        {
                            return;
                        }

                        hKBHook = SetHook(WM_KEYBOARD_LL, kbHookPinned, GetModule(currentModule.ModuleName!), 0);
                    }
                }
                tabPageKeyboard.Text = "Kb hook active";
                tabPageKeyboard.Tag = false;
            }
            else
            {
                MessageBox.Show("Already active");
            }
        }

        private void buttonStopKB_Click(object sender, EventArgs e)
        {
            if ((bool)tabPageKeyboard.Tag == false)
            {
                Unhook(hKBHook);
                kbGCHandle.Free();
                tabPageKeyboard.Text = "Kb hook inactive";
                tabPageKeyboard.Tag = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var source = (Keys)Enum.Parse(typeof(Keys), textBoxSource.Text);
                var destination = (Keys)Enum.Parse(typeof(Keys), textBoxDestination.Text);

                KeyValuePair<Keys, Keys> key = new KeyValuePair<Keys, Keys>(source, destination);

                foreach (var kvp in listBoxReplaces.Items)
                {
                    if (kvp.Equals(key))
                    {
                        throw new ArgumentException("Already in list");
                    }
                }

                listBoxReplaces.Items.Add(key);
                textBoxDestination.Text = "";
                textBoxSource.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid replace pair");
            }

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (sender is TextBox)
            {
                TextBox t = (sender as TextBox);
                t.Text = e.KeyData.ToString();
                return;
            }


        }

        #endregion

        #region MouseHook

        private HookProc MSHookPinned;
        private IntPtr hMSHook;
        private GCHandle msGCHandle;


        int Map(float value, float min1, float max1, float min2, float max2)
        {
            return (int)(min2 + (value - min1) * (max2 - min2) / (max1 - min1));
        }


        int PrevX;
        int PrevY;

        private IntPtr MSHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_LBUTTONDOWN)
            {
                MsHookStruct msHookStruct = Marshal.PtrToStructure<MsHookStruct>(lParam);

                labelMsX.Text = msHookStruct.point.x.ToString();
                labelMsY.Text = msHookStruct.point.y.ToString();

                listBoxMS.Items.Add("click");
            }

            if (nCode >= 0 && wParam == (IntPtr)WM_MOUSEMOVE)
            {

                MsHookStruct msHookStruct = Marshal.PtrToStructure<MsHookStruct>(lParam);

                labelMsX.Text = msHookStruct.point.x.ToString();
                labelMsY.Text = msHookStruct.point.y.ToString();

                int x = Map(msHookStruct.point.x, 0, 1918, 0, pictureBox1.Width);
                int y = Map(msHookStruct.point.y, 0, 1078, 0, pictureBox1.Height);

                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
                {
                    // I Prefer this over lines 
                    // Draws dots but saves when out of bounds and saves when stop button clicked
                    bitmap.SetPixel(x, y, Color.DarkCyan);
                    pictureBox1.Image = bitmap;


                    // Draw lines but cleans when out of bounds

                    //var g = pictureBox1.CreateGraphics();
                    //g.DrawLine(new Pen(Color.Black), PrevX, PrevY, x, y);
                    //bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, g);

                    //PrevX = x;
                    //PrevY = y;
                }

            }

            if (nCode >= 0 && wParam == (IntPtr)WM_RBUTTONDOWN)
            {
                MsHookStruct msHookStruct = Marshal.PtrToStructure<MsHookStruct>(lParam);

                labelMsX.Text = msHookStruct.point.x.ToString();
                labelMsY.Text = msHookStruct.point.y.ToString();

                listBoxMS.Items.Add("click");
            }

            return NextHook(hMSHook, nCode, wParam, lParam);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if ((bool)tabPageMouse.Tag == true)
            {

                using (Process currentProcess = Process.GetCurrentProcess())
                {
                    using (ProcessModule processModule = currentProcess.MainModule!)
                    {
                        MSHookPinned = MSHookProc;

                        msGCHandle = GCHandle.Alloc(MSHookPinned);

                        hMSHook = SetHook(WM_MOUSE_LL, MSHookPinned, GetModule(processModule.ModuleName!), 0);

                    }
                }

                tabPageMouse.Text = "Mouse hook active";
                tabPageMouse.Tag = false;
            }
            else
            {
                MessageBox.Show("Already active");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if ((bool)tabPageMouse.Tag == false)
            {
                tabPageMouse.Tag = true;
                Unhook(hMSHook);
                msGCHandle.Free();
                tabPageMouse.Text = "Mouse hook inactive";
                bitmap.Save("mouseMoves.png");
            }
        }
        #endregion

        #region Structures

        // Keyboard
        [StructLayout(LayoutKind.Sequential)]
        struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }


        // Mouse 
        [StructLayout(LayoutKind.Sequential)]
        struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MsHookStruct
        {
            public POINT point;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct INPUT
        {
            public uint Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public HARDWAREINPUT Hardware;
            [FieldOffset(0)]
            public KEYBDINPUT Keyboard;
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            public uint Msg;
            public ushort ParamL;
            public ushort ParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            public ushort Vk;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        #endregion


    }
}



