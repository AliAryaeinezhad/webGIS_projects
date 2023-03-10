using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Media_Counter
{
    public partial class MediaCounter : Form
    {
        public MediaCounter()
        {
            InitializeComponent();
        }

        private void btn_resualt_Click(object sender, EventArgs e)
        {
                openFile.Filter = "XML Files (*.xml)|*.xml";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // Get Path
                    string file_path = Path.GetFullPath(openFile.FileName);
                    PathLabel.Text = file_path;

                    int count = count_media.img_tag_count(file_path);
                    ResultLabel.Text = Convert.ToString(count);
                    MessageBox.Show(Convert.ToString(count));
                }

                else
                {
                    MessageBox.Show("Something went wrong! Please choose a file in correct format.");
                }
        }
    }
}