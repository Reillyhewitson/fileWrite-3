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
    public partial class addFile : UserControl
    {
        string directory = Path.GetDirectoryName(Application.ExecutablePath);
        public addFile()
        {
            InitializeComponent();
        }

        private void addFile_Load(object sender, EventArgs e)
        {

        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            Console.WriteLine(directory);
            string text = fileInput.Text;
            Console.WriteLine(text);
            string[] Lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Console.WriteLine(Lines);
            File.WriteAllLines(directory + "\\" + nameInput.Text + ".txt", Lines);
            MessageBox.Show("Success", "Written");
            fileInput.Text = string.Empty;
            nameInput.Text = string.Empty;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void directorySelect_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                directory = fbd.SelectedPath;
                Console.WriteLine(directory);
            }
        }
    }
}
