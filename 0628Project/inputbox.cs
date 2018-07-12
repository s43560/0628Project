using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0628Project
{
    public partial class inputbox : Form
    {
        public inputbox()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clickmouse.ooo = textBox1.Text;
            this.Close();
        }
    }
}
