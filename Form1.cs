using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Start();
        }

        private void userControl21_GreenLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }

        private void userControl21_OrangeLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());

        }

        private void userControl21_RedLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());
        }
    }
}
