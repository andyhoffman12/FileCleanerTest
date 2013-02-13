namespace WindowsFormsApplication1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonExecuteProcess = new System.Windows.Forms.Button();
            this.labelFileSelected = new System.Windows.Forms.Label();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(30, 29);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonExecuteProcess
            // 
            this.buttonExecuteProcess.Location = new System.Drawing.Point(152, 28);
            this.buttonExecuteProcess.Name = "buttonExecuteProcess";
            this.buttonExecuteProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteProcess.TabIndex = 1;
            this.buttonExecuteProcess.Text = "Process";
            this.buttonExecuteProcess.UseVisualStyleBackColor = true;
            this.buttonExecuteProcess.Click += new System.EventHandler(this.buttonExecuteProcess_Click);
            // 
            // labelFileSelected
            // 
            this.labelFileSelected.AutoSize = true;
            this.labelFileSelected.Location = new System.Drawing.Point(30, 74);
            this.labelFileSelected.Name = "labelFileSelected";
            this.labelFileSelected.Size = new System.Drawing.Size(85, 13);
            this.labelFileSelected.TabIndex = 2;
            this.labelFileSelected.Text = "No File Selected";
            this.labelFileSelected.Click += new System.EventHandler(this.labelFileSelected_Click);
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(30, 111);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(85, 13);
            this.labelOutputFile.TabIndex = 3;
            this.labelOutputFile.Text = "No File Selected";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "ckp Files|*.ckp|All Files|*.*";
            this.openFileDialog1.Title = "Open File with Nulls";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelOutputFile);
            this.Controls.Add(this.labelFileSelected);
            this.Controls.Add(this.buttonExecuteProcess);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "MainForm";
            this.Text = "ckp file cleaner v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonExecuteProcess;
        private System.Windows.Forms.Label labelFileSelected;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

