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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Dumbbell_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "덤벨" });
        }

        private void metalpole_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "철봉" });
        }

        private void armcurlmachine_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "압컬머신" });
        }

        private void Declinebench_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.File.AppendAllLines(@"C:\Users\csi2\Desktop\새 폴더\hackerton\hackerton\test.txt", new[] { "디클라인벤치" });
        }
    }
}
