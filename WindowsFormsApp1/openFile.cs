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
    public partial class openFile : UserControl
    {
        string directory = Path.GetDirectoryName(Application.ExecutablePath);

        public openFile()
        {
            InitializeComponent();
        }

        private void openFile_Load(object sender, EventArgs e)
        {

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

        private void fileWrite_Click(object sender, EventArgs e)
        {
            Console.WriteLine(directory);
            string text = fileInput.Text;
            Console.WriteLine(text);
            string[] Lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Console.WriteLine(Lines);
            File.AppendAllLines(directory, Lines);
            MessageBox.Show("Success", "Written");
            fileInput.Text = string.Empty;
        }

        private void openFile_Load_1(object sender, EventArgs e)
        {

        }
    }
}
