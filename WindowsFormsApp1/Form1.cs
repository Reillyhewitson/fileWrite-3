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

    public partial class Form1 : Form
    {

        addFile add = new addFile();
        openFile open = new openFile();
        readFile read = new readFile();
        fileDelete delete = new fileDelete();
        public Form1()
        {
            InitializeComponent();
            
            add.Dock = DockStyle.Bottom;
            open.Dock = DockStyle.Bottom;
            read.Dock = DockStyle.Bottom;
            delete.Dock = DockStyle.Bottom;
            this.Controls.Add(add);
            this.Controls.Add(open);
            this.Controls.Add(read);
            this.Controls.Add(delete);
            open.Visible = false;
            add.Visible = true;
            read.Visible = false;
            delete.Visible = false;
        }

        private void fileInput_TextChanged(object sender, EventArgs e)
        {

        }




        private void buttonActive_Click(object sender, EventArgs e)
        {
            

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        public void directorySelect_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            add.Visible = false;
            open.Visible = true;
            read.Visible = false;
            delete.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add.Visible = true;
            open.Visible = false;
            read.Visible = false;
            delete.Visible = false;
        }

        private void readFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add.Visible = false;
            open.Visible = false;
            read.Visible = true;
            delete.Visible = false;
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add.Visible = false;
            open.Visible = false;
            read.Visible = false;
            delete.Visible = true;
        }
    }
}
