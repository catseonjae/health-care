using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace hackerton
{
    public partial class Form1 : Form
    {
        public static readonly Form1 theForm1 = new Form1();
        public static readonly Form2 theForm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            String savePath = @"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt";
            string textValue = "1";
            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);
            Form2 first = new Form2();
            this.Hide();
            first.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String savePath = @"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt";
            string textValue = "2";
            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);
            Form2 first = new Form2();
            this.Hide();
            first.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
