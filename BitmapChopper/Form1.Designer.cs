namespace BitmapChopper
{
    partial class Form1
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
            this.txt_fileInput = new System.Windows.Forms.TextBox();
            this.btn_process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cellSizeX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cellSizeY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_outputFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cellsWide = new System.Windows.Forms.TextBox();
            this.txt_cellsHigh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_alphaFilepath = new System.Windows.Forms.TextBox();
            this.btn_origBrowse = new System.Windows.Forms.Button();
            this.btn_browseAlpha = new System.Windows.Forms.Button();
            this.btn_browseOutput = new System.Windows.Forms.Button();
            this.openFileOriginal = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileAlpha = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txt_fileInput
            // 
            this.txt_fileInput.Location = new System.Drawing.Point(12, 25);
            this.txt_fileInput.Name = "txt_fileInput";
            this.txt_fileInput.Size = new System.Drawing.Size(260, 20);
            this.txt_fileInput.TabIndex = 0;
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(102, 227);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(75, 23);
            this.btn_process.TabIndex = 7;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filepath: Original Image";
            // 
            // txt_cellSizeX
            // 
            this.txt_cellSizeX.Location = new System.Drawing.Point(57, 124);
            this.txt_cellSizeX.Name = "txt_cellSizeX";
            this.txt_cellSizeX.Size = new System.Drawing.Size(28, 20);
            this.txt_cellSizeX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cell Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // txt_cellSizeY
            // 
            this.txt_cellSizeY.Location = new System.Drawing.Point(57, 151);
            this.txt_cellSizeY.Name = "txt_cellSizeY";
            this.txt_cellSizeY.Size = new System.Drawing.Size(28, 20);
            this.txt_cellSizeY.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // txt_outputFolder
            // 
            this.txt_outputFolder.Location = new System.Drawing.Point(15, 196);
            this.txt_outputFolder.Name = "txt_outputFolder";
            this.txt_outputFolder.Size = new System.Drawing.Size(260, 20);
            this.txt_outputFolder.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filepath: Output Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cells Wide";
            // 
            // txt_cellsWide
            // 
            this.txt_cellsWide.Location = new System.Drawing.Point(204, 120);
            this.txt_cellsWide.Name = "txt_cellsWide";
            this.txt_cellsWide.Size = new System.Drawing.Size(26, 20);
            this.txt_cellsWide.TabIndex = 4;
            // 
            // txt_cellsHigh
            // 
            this.txt_cellsHigh.Location = new System.Drawing.Point(204, 151);
            this.txt_cellsHigh.Name = "txt_cellsHigh";
            this.txt_cellsHigh.Size = new System.Drawing.Size(26, 20);
            this.txt_cellsHigh.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Filepath: Alpha image";
            // 
            // txt_alphaFilepath
            // 
            this.txt_alphaFilepath.Location = new System.Drawing.Point(15, 69);
            this.txt_alphaFilepath.Name = "txt_alphaFilepath";
            this.txt_alphaFilepath.Size = new System.Drawing.Size(260, 20);
            this.txt_alphaFilepath.TabIndex = 1;
            // 
            // btn_origBrowse
            // 
            this.btn_origBrowse.Location = new System.Drawing.Point(280, 22);
            this.btn_origBrowse.Name = "btn_origBrowse";
            this.btn_origBrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_origBrowse.TabIndex = 8;
            this.btn_origBrowse.Text = "Browse";
            this.btn_origBrowse.UseVisualStyleBackColor = true;
            this.btn_origBrowse.Click += new System.EventHandler(this.btn_origBrowse_Click);
            // 
            // btn_browseAlpha
            // 
            this.btn_browseAlpha.Location = new System.Drawing.Point(280, 67);
            this.btn_browseAlpha.Name = "btn_browseAlpha";
            this.btn_browseAlpha.Size = new System.Drawing.Size(75, 23);
            this.btn_browseAlpha.TabIndex = 9;
            this.btn_browseAlpha.Text = "Browse";
            this.btn_browseAlpha.UseVisualStyleBackColor = true;
            this.btn_browseAlpha.Click += new System.EventHandler(this.btn_browseAlpha_Click);
            // 
            // btn_browseOutput
            // 
            this.btn_browseOutput.Location = new System.Drawing.Point(282, 192);
            this.btn_browseOutput.Name = "btn_browseOutput";
            this.btn_browseOutput.Size = new System.Drawing.Size(75, 23);
            this.btn_browseOutput.TabIndex = 10;
            this.btn_browseOutput.Text = "Browse";
            this.btn_browseOutput.UseVisualStyleBackColor = true;
            this.btn_browseOutput.Click += new System.EventHandler(this.btn_browseOutput_Click);
            // 
            // openFileOriginal
            // 
            this.openFileOriginal.FileName = "openFileOrignal";
            // 
            // openFileAlpha
            // 
            this.openFileAlpha.FileName = "openFileAlpha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.btn_browseOutput);
            this.Controls.Add(this.btn_browseAlpha);
            this.Controls.Add(this.btn_origBrowse);
            this.Controls.Add(this.txt_alphaFilepath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cellsHigh);
            this.Controls.Add(this.txt_cellsWide);
            this.Controls.Add(this.txt_outputFolder);
            this.Controls.Add(this.txt_cellSizeY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cellSizeX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.txt_fileInput);
            this.Name = "Form1";
            this.Text = "Image Chopper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fileInput;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cellSizeX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cellSizeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_outputFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cellsWide;
        private System.Windows.Forms.TextBox txt_cellsHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_alphaFilepath;
        private System.Windows.Forms.Button btn_origBrowse;
        private System.Windows.Forms.Button btn_browseAlpha;
        private System.Windows.Forms.Button btn_browseOutput;
        private System.Windows.Forms.OpenFileDialog openFileOriginal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserOutput;
        private System.Windows.Forms.OpenFileDialog openFileAlpha;
    }
}

