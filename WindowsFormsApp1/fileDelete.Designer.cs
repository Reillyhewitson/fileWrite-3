﻿namespace WindowsFormsApp1
{
    partial class fileDelete
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
            this.deleteFile = new System.Windows.Forms.Button();
            this.fileOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(0, 3);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(156, 23);
            this.fileSelect.TabIndex = 2;
            this.fileSelect.Text = "Select File";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(158, 3);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(156, 23);
            this.deleteFile.TabIndex = 3;
            this.deleteFile.Text = "Delete";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // fileOutput
            // 
            this.fileOutput.Location = new System.Drawing.Point(4, 32);
            this.fileOutput.Multiline = true;
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.Size = new System.Drawing.Size(307, 176);
            this.fileOutput.TabIndex = 15;
            // 
            // fileDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileOutput);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.fileSelect);
            this.Name = "fileDelete";
            this.Size = new System.Drawing.Size(314, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.TextBox fileOutput;
    }
}
