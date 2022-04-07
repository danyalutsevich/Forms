using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class _2048Form : Form
    {
        private Random random;
        private List<Label> labels;
        public Label[][] labels2D { get; set; }

        public _2048Form(Random random)
        {
            labels = new List<Label>();
            this.random = random;

            InitializeComponent();
        }

        int Map(float value, float min1, float max1, float min2, float max2)
        {
            return (int)(min2 + (value - min1) * (max2 - min2) / (max1 - min1));
        }

        private void ColorLabels()
        {
            foreach (var l in labels)
            {
                try
                {
                    if (l.Text == "")
                    {
                        l.BackColor = Color.FromArgb(160,160,160);
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
                    empty[random.Next(empty.Count)].Text = "2";
                }
                else
                {
                    empty[random.Next(empty.Count)].Text = "4";
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
            ClearGameField();

            this.ActiveControl = null;

            AddCell();
            ColorLabels();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelScrollValue.Text = hScrollBar1.Value.ToString();
            labelR.Text = hScrollBarR.Value.ToString();
            labelG.Text = hScrollBarG.Value.ToString();
            labelB.Text = hScrollBarB.Value.ToString();
            ColorLabels();
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

        private void _2048Form_KeyDown(object sender, KeyEventArgs e)
        {

            MoveCells(e.KeyData);
            AddCell();
            ColorLabels();


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

            if (key == Keys.Down || key==Keys.S)
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
                                labels2D[y + 1][x].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
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
                                labels2D[y - 1][x].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
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
                                labels2D[y][x - 1].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
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
                                labels2D[y][x + 1].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
                                labels2D[y][x].Text = "";
                            }
                        }
                        catch { }

                    }
                }

            }

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

        private void _2048Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown.X = e.X;
            mouseDown.Y = e.Y;

        }

        private void _2048Form_MouseUp(object sender, MouseEventArgs e)
        {

            mouseUp.X = e.X;
            mouseUp.Y = e.Y;
            SensorMove();
            AddCell();
            ColorLabels();
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
    
    }
}
