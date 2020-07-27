using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AutoItX3Lib;
using Lorai.ImgSearch;
using Lorai.Properties;

namespace Lorai
{
    public partial class LorAI : Form
    {
        AutoIT cAuIT = new AutoIT();
        public LorAI()
        {
            InitializeComponent();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            cAuIT.StartGame("PvE", 1);
        }
        private void btnEmoji_Click(object sender, EventArgs e)
        {
            cAuIT.Emoji("Shen");
        }
/*        private void btnDragNDrop_Click(object sender, EventArgs e)
        {
            // Precisa saber quantas cartas na mão e onde começar
            cAuIT.DragAndDrop(3049, 1056, 2851, 652, -1);
        }*/
        private void btnAllin_Click(object sender, EventArgs e)
        {
            cAuIT.Allin(3003, 923);
        }
        private void btnRAll_Click(object sender, EventArgs e)
        {
            SendKeys.Send("A");
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            //cAuIT.ReplaceCards(true, true, true, false);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {


            Stopwatch sw = new Stopwatch();
            sw.Start();

            Bitmap screenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics g = Graphics.FromImage(screenCapture);
            g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                             Screen.PrimaryScreen.Bounds.Y,
                             0, 0,
                             screenCapture.Size,
                             CopyPixelOperation.SourceCopy);

            Bitmap myPic = Resources.ip;

            bool isInCapture = IsInCapture(myPic, screenCapture);
            if (isInCapture == true)
            {
                rdBtn.Select();
            }

            sw.Stop();

            TimeSpan ts = sw.Elapsed;
        }
        private bool IsInCapture(Bitmap searchFor, Bitmap searchIn)
        {
            for (int x = 0; x < searchIn.Width; x++)
            {
                for (int y = 0; y < searchIn.Height; y++)
                {
                    bool invalid = false;
                    int k = x, l = y;
                    for (int a = 0; a < searchFor.Width; a++)
                    {
                        l = y;
                        for (int b = 0; b < searchFor.Height; b++)
                        {
                            if (searchFor.GetPixel(a, b) != searchIn.GetPixel(k, l))
                            {
                                invalid = true;
                                break;
                            }
                            else
                                l++;
                        }
                        if (invalid)
                            break;
                        else
                            k++;
                    }
                    if (!invalid)
                        return true;
                }
            }
            return false;
        }

    }
}