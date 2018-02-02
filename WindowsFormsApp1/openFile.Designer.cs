namespace WindowsFormsApp1
{
    partial class openFile
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
            this.fileSelect = new System.Windows.Forms.Button();
            this.fileWrite = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(0, 3);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(156, 23);
            this.fileSelect.TabIndex = 0;
            this.fileSelect.Text = "Select File";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // fileWrite
            // 
            this.fileWrite.Location = new System.Drawing.Point(158, 3);
            this.fileWrite.Name = "fileWrite";
            this.fileWrite.Size = new System.Drawing.Size(156, 23);
            this.fileWrite.TabIndex = 1;
            this.fileWrite.Text = "Write";
            this.fileWrite.UseVisualStyleBackColor = true;
            this.fileWrite.Click += new System.EventHandler(this.fileWrite_Click);
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(3, 32);
            this.fileInput.Multiline = true;
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(307, 176);
            this.fileInput.TabIndex = 13;
            // 
            // openFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.fileWrite);
            this.Controls.Add(this.fileSelect);
            this.Name = "openFile";
            this.Size = new System.Drawing.Size(314, 215);
            this.Load += new System.EventHandler(this.openFile_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button fileWrite;
        private System.Windows.Forms.TextBox fileInput;
    }
}
