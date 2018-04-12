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
    public partial class FormTHR : Form
    {
        public FormTHR()
        {
            InitializeComponent();
        }

        private void FormTHR_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            串口助手 form = new 串口助手();
            form.ShowDialog();
        }
    }
}
