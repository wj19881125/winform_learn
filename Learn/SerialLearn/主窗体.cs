using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialLearn
{
    public partial class 主窗体 : Form
    {
        public 主窗体()
        {
            InitializeComponent();
        }

        private void 主窗体_Load(object sender, EventArgs e)
        {

        }

        private void 主窗体_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void 主窗体_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void 主窗体_Click(object sender, EventArgs e)
        {
            //次窗体 form = new 次窗体();
            //form.ShowDialog();
        }

        private void bt_thr_Click(object sender, EventArgs e)
        {
            FormTHR form = new FormTHR();
            form.ShowDialog();
        }
    }
}
