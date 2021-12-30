using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.ComponentModel;

namespace BitmapChopper
{
    /// <summary>The Main Chopper.
    /// This object will chop an image into specified new images
    /// -Preserves the last line of pixels, as the first line in the next section
    ///     -This was created as an easier method for tiled terrain within XNA
    /// -RGB and Alpha are read from 2 separate images</summary>
    public sealed class Chopper
    {
        private int cellSizeX = 64;
        private int cellSizeY = 64;

        private int cellsWide = 8;
        private int cellsHigh = 8;

        Bitmap bitmap;
        Bitmap alphaBitmap;

        Bitmap[,] processed;

        /// <summary>Default ctor</summary>
        public Chopper()
        {    }

        /// <summary>load images from file</summary>
        /// <param name="filepath">rgb filepath</param>
        /// <param name="alphaFilepath">alpha filepath</param>
        /// <returns>false for failure</returns>
        public bool SetImage(string filepath, string alphaFilepath)
        {
            try
            {
                bitmap = new Bitmap(filepath);
                alphaBitmap = new Bitmap(alphaFilepath);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Could not find the original image(s)");
                string temp = e.StackTrace;
                return false;
            }
            return true;
        }

        /// <summary>reset the parameters of the chop settings</summary>
        /// <param name="cellSizeX">pixels wide</param>
        /// <param name="cellSizeY">pixels high</param>
        /// <param name="cellsWide">how many cells wide</param>
        /// <param name="cellsHigh">how many cells high</param>
        public void SetChopParameters(int cellSizeX, int cellSizeY, int cellsWide, int cellsHigh)
        {
            this.cellSizeX = cellSizeX;
            this.cellSizeY = cellSizeY;
            this.cellsWide = cellsWide;
            this.cellsHigh = cellsHigh;
        }

        /// <summary>Process the loaded images, and create new images</summary>
        public void Process()
        {
            processed = new Bitmap[cellsWide, cellsHigh];
            for (int x = 0; x < cellsWide; x++)
                for (int y = 0; y < cellsHigh; y++)
                    processed[x, y] = new Bitmap(cellSizeX, cellSizeY, PixelFormat.Format32bppArgb);

            Color color;
            //for every cell...
            for (int cellx = 0; cellx < cellsWide; cellx++)
            {
                for (int celly = 0; celly < cellsHigh; celly++)
                {

                    //for every pixel in that cell...
                    for (int pixelx = 0; pixelx < cellSizeX; pixelx++)
                    {
                        for (int pixely = 0; pixely < cellSizeY; pixely++)
                        {
                            int pX = (pixelx + (cellx * cellSizeX)) - cellx;
                            int pY = (pixely + (celly * cellSizeY)) - celly;

                            color = Color.FromArgb(
                                alphaBitmap.GetPixel(pX, pY).R,
                                bitmap.GetPixel(pX, pY).R,
                                bitmap.GetPixel(pX, pY).G,
                                bitmap.GetPixel(pX, pY).B );

                            processed[cellx, celly].SetPixel(pixelx, pixely, color);
                        }
                    }

                }
            }

        }

        /// <summary>Save the newly created images to the specified image</summary>
        /// <param name="folder">filepath to where the new images store</param>
        public void SaveProcessedImages(string folder)
        {
            for (int x = 0; x < cellsWide; x++)
                for (int y = 0; y < cellsHigh; y++)
                {
                    Bitmap bmp = new Bitmap(processed[x, y]);
                    bmp.MakeTransparent();

                    BitmapData bmData;
                    Rectangle bmBounds = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    bmData = bmp.LockBits(bmBounds, ImageLockMode.ReadOnly, bmp.PixelFormat);

                    Bitmap dstBitmap = new Bitmap(bmData.Width,
                        bmData.Height,
                        bmData.Stride,
                        PixelFormat.Format32bppArgb,
                        bmData.Scan0);

                    dstBitmap.Save(folder + "\\" + x + y + ".bmp", ImageFormat.Bmp);
                }
        }
    }
}
