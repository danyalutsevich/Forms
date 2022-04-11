using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class _2048Form : Form
    {
        private Random random;
        private List<Label> labels;
        private Label[][] labels2D { get; set; }
        private int TimeMS { get; set; }
        private List<Label> LabelsToAnimate { get; set; }
        private List<GameState> states { get; set; }
        private long Record;

        public _2048Form(Random random)
        {
            LabelsToAnimate = new List<Label>();
            labels = new List<Label>();
            this.random = random;
            TimeMS = 0;

            Record = 0;

            states = new List<GameState>();

            InitializeComponent();
        }

        int Map(float value, float min1, float max1, float min2, float max2)
        {
            return (int)(min2 + (value - min1) * (max2 - min2) / (max1 - min1));
        }

        private void ColorCells()
        {
            foreach (var l in labels)
            {
                try
                {
                    if (l.Text == "")
                    {
                        l.BackColor = Color.FromArgb(160, 160, 160);
                    }
                    else
                    {
                        var text = Convert.ToInt32(l.Text);
                        var mappedValue = Map((text * hScrollBar1.Value) % 2048, 0, 2048, 0, 255) % 255;
                        Color color = Color.FromArgb((mappedValue + hScrollBarR.Value) % 256, (mappedValue + hScrollBarG.Value) % 256, (mappedValue + hScrollBarB.Value) % 256);

                        l.BackColor = color;
                    }
                }
                catch { }
            }
        }

        private void ClearGameField()
        {
            foreach (var l in labels)
            {
                l.Text = "";
            }
        }

        private void AddCell()
        {
            var amount = random.Next(2) + 1;

            var value = 0;

            var empty = labels.Where(i => i.Text == "").ToList();


            if (empty.Count == 0)
            {
                MessageBox.Show("Game Over");
                return;
            }

            for (int i = 0; i <= amount; i++)
            {
                value = random.Next(11);
                if (value <= 9)
                {
                    var index = random.Next(empty.Count);
                    empty[index].Text = "2";
                    LabelsToAnimate.Add(empty[index]);
                    R = 0;
                    timerAnimation.Start();
                }
                else
                {
                    var index = random.Next(empty.Count);
                    empty[index].Text = "4";
                    LabelsToAnimate.Add(empty[index]);
                }
            }
        }

        private void _2048Form_Load(object sender, EventArgs e)
        {

            foreach (var c in panel1.Controls)
            {
                var label = c as Label;
                if (label is not null)
                {
                    labels.Add(label);
                }
            }

            labels2D = To2DArray();

            if (!LoadFieldFromFile())
            {
                ClearGameField();
                this.ActiveControl = null;
                AddCell();
            }

            ColorCells();
            timerClock.Start();

        }

        private bool LoadFieldFromFile()
        {
            try
            {
                string text;

                using (var sr = new StreamReader("savegame.json"))
                {
                    text = sr.ReadToEnd();
                }

                GameState state = JsonSerializer.Deserialize<GameState>(text);

                SetState(state);
            }
            catch
            {
                return false;
            }
            return true;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelScrollValue.Text = hScrollBar1.Value.ToString();
            labelR.Text = hScrollBarR.Value.ToString();
            labelG.Text = hScrollBarG.Value.ToString();
            labelB.Text = hScrollBarB.Value.ToString();
            ColorCells();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCell();
        }

        private Label[][] To2DArray()
        {
            Label[][] l = new Label[4][];

            for (int i = 0; i < 4; i++)
            {
                l[i] = new Label[4];
            }

            int x = 0;
            int y = 0;


            for (int i = 0; i < labels.Count; i++)
            {
                x = i % 4;

                if (i % 4 == 0 && i != 0)
                {
                    y++;
                }

                l[y][x] = labels[i];

            }
            return l;
        }

        private GameState GetState()
        {
            var tempState = new GameState();
            tempState.Record = this.Record;

            for (int i = 0; i < labels2D.Length; i++)
            {
                for (int j = 0; j < labels2D[i].Length; j++)
                {
                    try
                    {
                        tempState.Field[i][j] = Convert.ToInt32(labels2D[i][j].Text);
                    }
                    catch
                    {
                        tempState.Field[i][j] = 0;
                    }
                }
            }
            return tempState;
        }

        private void SetState(GameState state)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (state.Field[i][j] > 0)
                        {
                            labels2D[i][j].Text = state.Field[i][j].ToString();
                        }
                        else
                        {
                            labels2D[i][j].Text = "";
                        }
                    }
                }
            }
            catch { }

        }

        private void _2048Form_KeyDown(object sender, KeyEventArgs e)
        {
            MoveCells(e.KeyData);
        }

        enum MoveDirection
        {
            Up = Keys.Up,
            Down = Keys.Down,
            Left = Keys.Left,
            Right = Keys.Right,
        }

        private void MoveCells(Keys key)
        {
            //        x y 
            // Up     0 0
            // Down   3 3

            //        y x
            // Right  0 0
            // Left   3 3

            states.Add(GetState());

            if (key == Keys.Down || key == Keys.S)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        try
                        {
                            int x = j;
                            int y = i;

                            while (labels2D[y + 1][x].Text == "")
                            {
                                labels2D[y + 1][x].Text = labels2D[y][x].Text;
                                labels2D[y][x].Text = "";
                                y++;
                            }

                            if (labels2D[y][x].Text == labels2D[y + 1][x].Text)
                            {
                                var value = Convert.ToInt32(labels2D[y][x].Text) * 2;
                                Record += value;
                                labels2D[y + 1][x].Text = value.ToString();
                                LabelsToAnimate.Add(labels2D[y + 1][x]);
                                labels2D[y][x].Text = "";
                            }
                        }
                        catch { }

                    }
                }
            }
            else if (key == Keys.Up || key == Keys.W)
            {
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        try
                        {
                            int x = j;
                            int y = i;

                            while (labels2D[y - 1][x].Text == "")
                            {
                                labels2D[y - 1][x].Text = labels2D[y][x].Text;
                                labels2D[y][x].Text = "";
                                y--;
                            }

                            if (labels2D[y][x].Text == labels2D[y - 1][x].Text)
                            {
                                var value = Convert.ToInt32(labels2D[y][x].Text) * 2;
                                Record += value;
                                labels2D[y - 1][x].Text = value.ToString();
                                LabelsToAnimate.Add(labels2D[y - 1][x]);
                                labels2D[y][x].Text = "";
                            }
                        }
                        catch { }
                    }
                }
            }
            else if (key == Keys.Left || key == Keys.A)
            {
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        try
                        {
                            int x = i;
                            int y = j;

                            while (labels2D[y][x - 1].Text == "")
                            {
                                labels2D[y][x - 1].Text = labels2D[y][x].Text;
                                labels2D[y][x].Text = "";
                                x--;
                            }

                            if (labels2D[y][x].Text == labels2D[y][x - 1].Text)
                            {
                                var value = Convert.ToInt32(labels2D[y][x].Text) * 2;
                                Record += value;
                                labels2D[y][x - 1].Text = value.ToString();
                                LabelsToAnimate.Add(labels2D[y][x - 1]);
                                labels2D[y][x].Text = "";
                            }
                        }
                        catch { }
                    }
                }
            }
            else if (key == Keys.Right || key == Keys.D)
            {

                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        try
                        {
                            int x = i;
                            int y = j;

                            while (labels2D[y][x + 1].Text == "")
                            {
                                labels2D[y][x + 1].Text = labels2D[y][x].Text;
                                labels2D[y][x].Text = "";
                                x++;
                            }

                            if (labels2D[y][x].Text == labels2D[y][x + 1].Text)
                            {
                                var value = Convert.ToInt32(labels2D[y][x].Text) * 2;
                                Record += value;
                                labels2D[y][x + 1].Text = value.ToString();
                                LabelsToAnimate.Add(labels2D[y][x + 1]);
                                labels2D[y][x].Text = "";
                            }
                        }
                        catch { }

                    }
                }

            }


            if (key == Keys.Down || key == Keys.S)
            {
                AddCell();
                ColorCells();
            }
            else if (key == Keys.Up || key == Keys.W)
            {
                AddCell();
                ColorCells();
            }
            else if (key == Keys.Left || key == Keys.A)
            {
                AddCell();
                ColorCells();
            }
            else if (key == Keys.Right || key == Keys.D)
            {
                AddCell();
                ColorCells();
            }

            labelRecord.Text = Record.ToString();

        }

        private void checkBoxControls_CheckedChanged(object sender, EventArgs e)
        {
            hScrollBar1.Enabled = checkBoxControls.Checked;
            hScrollBarR.Enabled = checkBoxControls.Checked;
            hScrollBarG.Enabled = checkBoxControls.Checked;
            hScrollBarB.Enabled = checkBoxControls.Checked;

            hScrollBar1.Visible = checkBoxControls.Checked;
            hScrollBarR.Visible = checkBoxControls.Checked;
            hScrollBarG.Visible = checkBoxControls.Checked;
            hScrollBarB.Visible = checkBoxControls.Checked;


        }

        private Point mouseUp;
        private Point mouseDown;
        private bool IsMouseDown = false;
        private bool IsMouseEnter = false;

        private void _2048Form_MouseEnter(object sender, EventArgs e)
        {
            IsMouseEnter = true;
        }

        private void _2048Form_MouseLeave(object sender, EventArgs e)
        {
            IsMouseEnter = false;
        }

        private void _2048Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown.X = e.X;
            mouseDown.Y = e.Y;
            IsMouseDown = true;
        }

        private void _2048Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown && IsMouseEnter)
            {

                mouseUp.X = e.X;
                mouseUp.Y = e.Y;
                SensorMove();
                AddCell();
                ColorCells();

                IsMouseDown = false;
            }
        }

        private void SensorMove()
        {

            if (Math.Abs(mouseUp.X - mouseDown.X) < Math.Abs(mouseUp.Y - mouseDown.Y))
            {

                if (mouseUp.Y < mouseDown.Y)  // Up
                {
                    MoveCells((Keys)MoveDirection.Up);
                }
                else  // Down
                {
                    MoveCells((Keys)MoveDirection.Down);

                }

            }
            else
            {
                if (mouseUp.Y < mouseDown.Y)  // Left
                {
                    MoveCells((Keys)MoveDirection.Left);

                }
                else  // Rigth
                {
                    MoveCells((Keys)MoveDirection.Right);

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeMS += timerClock.Interval;
            var ts = TimeSpan.FromMilliseconds(TimeMS);

            labelTimer.Text = $"{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}";
        }

        public int R = 0;
        public int G = 0;
        public int B = 0;

        private bool FontAnimationflag = false;

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (animateToolStripMenuItem.Checked)
            {
                foreach (var l in LabelsToAnimate)
                {
                    if (l.Text == "2")
                    {
                        LabelColorAnimation(l, l.BackColor);
                    }
                    else
                    {
                        if (l.Font.Size > 40)
                        {
                            FontAnimationflag = false;
                        }
                        else if (l.Font.Size < 27)
                        {
                            FontAnimationflag = true;
                        }
                        if (FontAnimationflag)
                        {
                            l.Font = new Font(l.Font.FontFamily, l.Font.Size + 1);
                        }
                        else
                        {
                            l.Font = new Font(l.Font.FontFamily, l.Font.Size - 1);
                        }

                        LabelColorAnimation(l, l.BackColor);
                    }
                }

                R++;
                LabelsToAnimate = LabelsToAnimate.Where(i => i.BackColor.A < 250).ToList();


                if (R > 25)
                {
                    timerAnimation.Stop();
                }

            }

        }

        private void LabelColorAnimation(Label l, Color color)
        {
            l.BackColor = Color.FromArgb(R * 10, color);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to leave?", "Confirm", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Close();
            }

        }

        private void topmostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = topmostToolStripMenuItem.Checked;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (states.Count > 0)
            {
                SetState(states[states.Count - 1]);
                states.RemoveAt(states.Count - 1);
                ColorCells();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Application.StartupPath;

            openFileDialog1.FileName = "savegame.json";

            openFileDialog1.Filter = "Json|*.json|All Files|*.*";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = Application.StartupPath;

            saveFileDialog1.FileName = "savegame.json";

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }

            using (var sw = new StreamWriter(saveFileDialog1.FileName))
            {
                sw.Write(JsonSerializer.Serialize(GetState()));
            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGameField();
            AddCell();
            ColorCells();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is clone of famous game 2048");
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find the rules in google");
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Record.ToString());
        }
    }

    class GameState
    {
        public int[][] Field { get; set; }
        public long Record;
        public GameState()
        {
            Record = 0;
            Field = new int[4][];
            for (int i = 0; i < Field.Length; i++)
            {
                Field[i] = new int[4];
            }
        }
    }

    class Interpolator
    {
        public static int Linear(int from, int to, int percent)
        {
            return from + (to - from) * percent / 100;
        }
    }


    class AnimData
    {


    }
}