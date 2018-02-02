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
    
    public partial class readFile : UserControl
    {
        string directory = Path.GetDirectoryName(Application.ExecutablePath);
        public readFile()
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
        }

        private void fileRead_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(directory);
            string output = string.Join(Environment.NewLine, lines);
            Console.WriteLine(output);
            fileOutput.Text = output;
        }
    }
}
