using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzimuthCalculator
{
    public partial class azimuth : Form
    {
        public azimuth()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double latitude1 = double.Parse(lat1.Text) * (Math.PI / 180);
                double longitude1 = double.Parse(long1.Text) * (Math.PI / 180);
                double latitude2 = double.Parse(lat2.Text) * (Math.PI / 180);
                double longitude2 = double.Parse(long2.Text) * (Math.PI / 180);

                double azimuth = Calculation.azimuth(latitude1, longitude1, latitude2, longitude2);
                azimuth = Math.Round(azimuth, 10);
                result.Text = Convert.ToString(azimuth);
                MessageBox.Show(Convert.ToString(azimuth));
            }
            catch
            {
                MessageBox.Show("Something went wrong! Please check the input variables.");
            }
        }
    }
}
