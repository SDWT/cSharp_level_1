using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HW7_3
{
    public partial class TextForm : Form
    {
        /// <summary>
        /// данные формы
        /// </summary>
        private FormData data;

        //public TextForm()
        //{
        //    data = new FormData();
        //    InitializeComponent();
        //}

        /// <summary>
        /// Конструктор от данных формы
        /// </summary>
        /// <param name="db"></param>
        public TextForm(FormData db)
        {
            data = new FormData(db);
            InitializeComponent();
            //.AppendText(db.ToString());
            richTextBox1.LoadFile("Form.rtf");
            string[] str = richTextBox1.Rtf.Split('<', '>');
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case "name1":
                        str[i] = data.Company;
                        break;
                    case "name2":
                        str[i] = data.Director;
                        break;
                    case "name3":
                        str[i] = data.Position;
                        break;
                    case "name4":
                        str[i] = data.NameSp;
                        break;
                    case "name5":
                        str[i] = data.Name;
                        break;
                    case "data1":
                        str[i] = data.DayStart.ToShortDateString();
                        break;
                    case "data2":
                        str[i] = data.DayFinish.ToShortDateString();
                        break;
                    case "data3":
                        str[i] = data.Day.ToShortDateString();
                        break;
                    default:
                        break;
                }
            }
            richTextBox1.Rtf = string.Concat(str);
            //textBox1.Text = db.ToString();
        }

        private void TextForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// обработчик кнопки создания заявления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            Directory.CreateDirectory(drives[0] + "docs");
            richTextBox1.SaveFile(drives[0] + "docs\\Заявление.rtf");
            Process.Start("explorer.exe", drives[0] + "docs");
            this.Close();
        }
    }
}
