using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloomySpiderLogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long LogInResult;
            if (axKHOpenAPI1.GetConnectState() == 0)
            {
                LogInResult = axKHOpenAPI1.CommConnect();
            }
            else
            {
            }
        }
    }
}
