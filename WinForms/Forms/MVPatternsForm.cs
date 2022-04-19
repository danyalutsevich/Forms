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
using System.IO;

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
            textBoxModel.Text = "Data provider (File, DataBase or Web Resource " +
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

            textBoxMVVM.Text = "ViewModel - модуль обеспечивающий двустороннюю связь (binding) модели и представления" +
                "это означает что изменения отслеживаются и обновляется представление и наоборот все изменения " +
                "в представленных данных сразу попадает в модель " +
                "Такая связь в WinForms изменения их свойств сразу отображаются в форме ";
        }

        private void textBoxMVPView_Click(object sender, EventArgs e)
        {
            textBoxMVPView.Text = "";
            int[] randoms = Program.Container.Resolve<RndModel>().getRandoms(4);

            foreach (var r in randoms)
            {
                textBoxMVPView.Text += r + " ";
            }

        }

        private DemoModel model = new DemoModel("demo.txt");                         // Model
        private DemoSecondModel secondModel = new DemoSecondModel("demo2.txt");      // Second Model

        private void tabPageDemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPageDemo.SelectedIndex == 1)
            {
                textBoxMVPView.Text = "";
                int[] randoms = Program.Container.Resolve<RndModel>().getRandoms(4);

                foreach (var r in randoms)
                {
                    textBoxMVPView.Text += r + " ";
                }
            }
            else if (tabPageDemo.SelectedIndex == 3)
            {

                // first model
                model.changeEvent += OnModelChanged;        // Event handler
                richTextBox1.TextChanged += (s, e) =>          // Model -> View
                {
                    model.Content = richTextBox1.Text;
                };
                richTextBox1.Text = model.Content;          // View init

                // second model
                secondModel.SecondModelChangeEvent += OnSecondModelChanged;  //
                richTextBoxSecondModel.TextChanged += (s, e) =>
                {
                    // setting new content (model) that will appear in view
                    secondModel.SetContent(richTextBoxSecondModel.Text);  
                };

                richTextBoxSecondModel.Text = secondModel.GetContent();  // updating view
            }
        }

        // executes when model changes
        private void OnModelChanged()
        {
            labelSymbolsCMD.Text = model.Content.Length.ToString();
        }

        private void OnSecondModelChanged()
        {
            labelSymbolsSecondModel.Text = secondModel.GetContent().Length.ToString();
        }
    }

    delegate void ModelChangeEvent();

    class DemoSecondModel
    {

        private string content;   // Model
        private string fileName;  // Model storage

        public DemoSecondModel(string fileName)
        {
            this.fileName = fileName;

            if (File.Exists(fileName))
            {
                using (var sr = new StreamReader(fileName))
                {
                    content = sr.ReadToEnd();
                }
            }
            else
            {
                content = String.Empty;
            }
        }

        public void SetContent(string content)
        {
            this.content = content;  // setting a new model
            using (var sw = new StreamWriter(fileName))
            {
               sw.Write(content);
            }
            SecondModelChangeEvent?.Invoke();   // update view
        }

        public string GetContent()
        {
            return content;
        }

        public event ModelChangeEvent? SecondModelChangeEvent;

    }

    class DemoModel
    {
        // fileName - data storage

        private string content; // file content
        private string fileName;

        public DemoModel(string fileName)
        {
            this.fileName = fileName;
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);
            }
            else
            {
                content = String.Empty;
            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                content = value;

                using (var sw = new StreamWriter(fileName))
                {
                    sw.WriteAsync(content);
                }

                changeEvent.Invoke();
            }
        }

        public event ModelChangeEvent changeEvent;
    }

    // model example - data provider
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
