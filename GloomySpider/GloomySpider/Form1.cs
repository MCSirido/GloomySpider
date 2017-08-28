using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace GloomySpider
{
    public partial class MainFrom : MetroFramework.Forms.MetroForm
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            long Result;
            Result = axKHOpenAPI1.CommConnect();
            if (Result != 0)
                MessageBox.Show("Login창 열림 Fail");
        }
    }
}
