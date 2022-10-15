using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackerton
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void levelinputbutton_Click(object sender, System.EventArgs e)
        {

            if (leveltext.Text == "s")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[]{ "1" });
            }
            else if (leveltext.Text == "a")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "2" });
            }
            else if (leveltext.Text == "b")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "3" });
            }
            else if (leveltext.Text == "c")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "4" });
            }
            else if (leveltext.Text == "d")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "5" });
            }
            else if (leveltext.Text == "e")
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "6" });
            }
        }

        private void level_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
