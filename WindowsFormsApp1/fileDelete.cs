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

namespace WindowsFormsApp1
{
    public partial class fileDelete : UserControl
    {
        string directory = Path.GetDirectoryName(Application.ExecutablePath);
        public fileDelete()
        {
            InitializeComponent();
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                fbd.Filter = "Text files (*.txt)|*.txt";
                DialogResult result = fbd.ShowDialog();
                directory = fbd.FileName;
                Console.WriteLine(directory);
            }
            string[] lines = File.ReadAllLines(directory);
            string output = string.Join(Environment.NewLine, lines);
            Console.WriteLine(output);
            fileOutput.Text = output;
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?","Caution" ,MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                File.Delete(directory);
                fileOutput.Text = string.Empty;
            }
            else
            {
                fileOutput.Text = string.Empty;
            }
            
        }
    }
}
