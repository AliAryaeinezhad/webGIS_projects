using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stPRJ_AliAryaeiNejad_810301021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double X1 = double.Parse(textBox1.Text);
                double Y1 = double.Parse(textBox2.Text);
                double X2 = double.Parse(textBox3.Text);
                double Y2 = double.Parse(textBox4.Text);

                double delta_X = X2 - X1;
                double delta_Y = Y2 - Y1;

                double azimuth = Math.Atan2(delta_X, delta_Y);

                azimuth = ((azimuth * 180) / Math.PI);

                if (delta_X < 0)
                {
                    azimuth = azimuth + 360;
                }

                azimuth = Math.Round(azimuth, 8);
                label5.Text = Convert.ToString(azimuth);
                MessageBox.Show(Convert.ToString(azimuth));
            }

            catch
            {
                MessageBox.Show("Something went wrong! Please check input the variables.");
            }
        }
    }
}
