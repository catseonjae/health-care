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

            if (0<= Convert.ToInt16(leveltext.Text) && 3>=Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[]{ "E" });
            }
            else if (4 <= Convert.ToInt16(leveltext.Text) && 10 >= Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "D" });
            }
            else if (11 <= Convert.ToInt16(leveltext.Text) && 30 >= Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "C" });
            }
            else if (31 <= Convert.ToInt16(leveltext.Text) && 50 >= Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "B" });
            }
            else if (51 <= Convert.ToInt16(leveltext.Text) && 100 >= Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "A" });
            }
            else if (101<= Convert.ToInt16(leveltext.Text))
            {
                System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "S" });
            }
            Form3 first = new Form3();
            this.Hide();
            first.Show();
        }

        private void level_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
