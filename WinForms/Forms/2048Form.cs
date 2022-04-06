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
                    var text = Convert.ToInt32(l.Text);
                    var mappedValue = Map((text * hScrollBar1.Value) % 2048, 0, 2048, 0, 255) % 255;
                    Color color = Color.FromArgb((mappedValue + hScrollBarR.Value) % 256, (mappedValue + hScrollBarG.Value) % 256, (mappedValue + hScrollBarB.Value) % 256);

                    l.BackColor = color;
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


            //int x = 0;
            //int y = 0;

            //int counter = 0;

            //for (int i = amount; i >= 0;)
            //{
            //    x = random.Next(4);
            //    y = random.Next(4);
            //    counter++;
            //    label1.Text=counter.ToString();

            //    if (labels2D[y][x].Text == "")
            //    {
            //        if (value <= 9)
            //        {
            //            labels2D[y][x].Text = "2";
            //        }
            //        else
            //        {
            //            labels2D[y][x].Text = "4";
            //        }
            //        i--;
            //    }
            //}


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

            //var sb = new StringBuilder();

            //for(int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        sb.Append(labels2D[i][j].Name+" ");
            //    }
            //    sb.AppendLine();
            //}

            //MessageBox.Show(sb.ToString());

            ClearGameField();
            ColorLabels();
            AddCell();

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



        }

        private void MoveCells(Keys key)
        {
            //        x y 
            // Up     0 0
            // Down   3 3

            //        y x
            // Right  0 0
            // Left   3 3

            if (key == Keys.Down)
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

                            #region old Version

                            //while (labels2D[y + 1][x].Text == ""
                            //    || labels2D[y][x].Text == labels2D[y + 1][x].Text)
                            //{
                            //    if (y + 1 >= 3)
                            //    {
                            //        break;
                            //    }
                            //    if (labels2D[y][x].Text == labels2D[y + 1][x].Text)
                            //    {

                            //        labels2D[y + 1][x].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
                            //        labels2D[y][x].Text = "";
                            //    }

                            //    if (labels2D[y + 1][x].Text == "")
                            //    {
                            //        labels2D[y + 1][x].Text = labels2D[y][x].Text;
                            //        labels2D[y][x].Text = "";
                            //    }
                            //    y++;
                            //}
                            #endregion
                        }
                        catch { }

                    }
                }
            }
            else if (key == Keys.Up)
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
                                y++;
                            }

                            if (labels2D[y][x].Text == labels2D[y - 1][x].Text)
                            {
                                labels2D[y - 1][x].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
                                labels2D[y][x].Text = "";
                            }

                            #region old Version

                            //while (labels2D[y + 1][x].Text == ""
                            //    || labels2D[y][x].Text == labels2D[y + 1][x].Text)
                            //{
                            //    if (y + 1 >= 3)
                            //    {
                            //        break;
                            //    }
                            //    if (labels2D[y][x].Text == labels2D[y + 1][x].Text)
                            //    {

                            //        labels2D[y + 1][x].Text = (Convert.ToInt32(labels2D[y][x].Text) * 2).ToString();
                            //        labels2D[y][x].Text = "";
                            //    }

                            //    if (labels2D[y + 1][x].Text == "")
                            //    {
                            //        labels2D[y + 1][x].Text = labels2D[y][x].Text;
                            //        labels2D[y][x].Text = "";
                            //    }
                            //    y++;
                            //}
                            #endregion
                        }
                        catch { }
                    }
                }
            }

        }

        private void checkBoxControls_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxControls.Checked)
            {

                hScrollBar1.Enabled = false;
                hScrollBarR.Enabled = false;
                hScrollBarG.Enabled = false;
                hScrollBarB.Enabled = false;
                button1.Enabled = false;
            }

        }
    }
}
