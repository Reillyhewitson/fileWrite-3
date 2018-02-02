namespace WindowsFormsApp1
{
    partial class addFile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directorySelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.buttonActive = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // directorySelect
            // 
            this.directorySelect.Location = new System.Drawing.Point(3, 3);
            this.directorySelect.Name = "directorySelect";
            this.directorySelect.Size = new System.Drawing.Size(92, 23);
            this.directorySelect.TabIndex = 8;
            this.directorySelect.Text = "Select Directory";
            this.directorySelect.UseVisualStyleBackColor = true;
            this.directorySelect.Click += new System.EventHandler(this.directorySelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(159, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 10;
            // 
            // buttonActive
            // 
            this.buttonActive.Location = new System.Drawing.Point(265, 6);
            this.buttonActive.Name = "buttonActive";
            this.buttonActive.Size = new System.Drawing.Size(45, 23);
            this.buttonActive.TabIndex = 11;
            this.buttonActive.Text = "Write";
            this.buttonActive.UseVisualStyleBackColor = true;
            this.buttonActive.Click += new System.EventHandler(this.buttonActive_Click);
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(4, 32);
            this.fileInput.Multiline = true;
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(307, 176);
            this.fileInput.TabIndex = 12;
            // 
            // addFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.buttonActive);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directorySelect);
            this.Name = "addFile";
            this.Size = new System.Drawing.Size(314, 215);
            this.Load += new System.EventHandler(this.addFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button directorySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button buttonActive;
        private System.Windows.Forms.TextBox fileInput;
    }
}
