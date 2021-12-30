using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitmapChopper
{
    public partial class Form1 : Form
    {
        private Chopper chopper = new Chopper();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            if (chopper.SetImage(this.txt_fileInput.Text, this.txt_alphaFilepath.Text) == false)
                return;

            chopper.SetChopParameters(
                int.Parse(this.txt_cellSizeX.Text), 
                int.Parse(this.txt_cellSizeY.Text), 
                int.Parse(this.txt_cellsWide.Text), 
                int.Parse(this.txt_cellsHigh.Text) );

            chopper.Process();

            chopper.SaveProcessedImages(this.txt_outputFolder.Text);
        }

        private void btn_origBrowse_Click(object sender, EventArgs e)
        {
            this.openFileOriginal.ShowDialog();
            this.txt_fileInput.Text = this.openFileOriginal.FileName;
        }

        private void btn_browseAlpha_Click(object sender, EventArgs e)
        {
            this.openFileAlpha.ShowDialog();
            this.txt_alphaFilepath.Text = this.openFileAlpha.FileName;
        }

        private void btn_browseOutput_Click(object sender, EventArgs e)
        {
            this.folderBrowserOutput.ShowDialog();
            this.txt_outputFolder.Text = this.folderBrowserOutput.SelectedPath;
        }


    }
}
