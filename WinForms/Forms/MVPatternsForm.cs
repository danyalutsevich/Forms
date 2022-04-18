using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace WinForms.Forms
{
    public partial class MVPatternsForm : Form
    {
        public MVPatternsForm()
        {
            InitializeComponent();
        }

        private void MVPatternsForm_Load(object sender, EventArgs e)
        {
            textBoxModel.Text = "Date provider (File, DataBase or Web Resource " +
                "from which and to which application data is transferred )";

            textBoxView.Text = "User Interface. Elements for displaying and data input.()";

            textBoxMVC.Text = "Контроллер посредник между пользователем, моделью и представлением" +
                "Пользователь через представление взаимодействует с контроллером, он анализируя запрос" +
                "выбирает нужную модель и нужное представление, передает пользователю новое" +
                " представление, заполненное даными из модели";

            labelMVP.Text = "Presenter соотносится с представлением\n" +
                "Обрабатывает события UI и общается с\n" +
                "моделями в зависимости от событий\n" +
                "Пример - WinForms:\n" +
                "Presenter - Form.cs\n" +
                "View - Form.designer.cs\n" +
                "Model - сохрененые данные";
        }

        private void textBoxMVPView_Click(object sender, EventArgs e)
        {
            textBoxMVPView.Text = "";
            int[] randoms = Program.Container.Resolve<RndModel>().getRandoms(4);

            foreach(var r in randoms)
            {
                textBoxMVPView.Text += r + " ";
            }

        }
    }


    //пример модели - поставщик данных
    class RndModel
    {
        private Random rand;
        public RndModel(Random random)
        {
            rand = random;
        }

        public int[] getRandoms(int count)
        {
            int[] randoms = new int[count];
            for (int i = 0; i < count; i++)
            {
                randoms[i] = rand.Next(count);
            }
            return randoms;
        }

    }
}
