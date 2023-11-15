using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaOdev1
{
    public partial class Form1 : Form
    {
        private int red, green, blue;
        private double hue, saturation, value, r, g, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbrRed_ValueChanged(object sender, EventArgs e)
        {
            red = tbrRed.Value;
            lblRed.Text = tbrRed.Value.ToString();
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }
        private void tbrGreen_ValueChanged(object sender, EventArgs e)
        {
            green = tbrGreen.Value;
            lblGreen.Text = tbrGreen.Value.ToString();
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }
        private void tbrBlue_ValueChanged(object sender, EventArgs e)
        {
            blue = tbrBlue.Value;
            lblBlue.Text = tbrBlue.Value.ToString();
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }
        private void tbrRed_Scroll(object sender, EventArgs e)
        {
            RGBtoHSV();
        }

        private void tbrGreen_Scroll(object sender, EventArgs e)
        {
            RGBtoHSV();
        }

        private void tbrBlue_Scroll(object sender, EventArgs e)
        {
            RGBtoHSV();
        }

        private void RGBtoHSV()
        {
            r = (double)red / 255;
            g = (double)green / 255;
            b = (double)blue / 255;

            double cmax = Math.Max(r, Math.Max(g, b));
            double cmin = Math.Min(r, Math.Min(g, b));
            double diff = cmax - cmin;

            if (cmax == cmin)
                hue = 0;

            else if (cmax == r)
            {
                hue = (60 * ((g - b) / diff) + 360) % 360;
                if (hue < 0) hue += 360;
            }
            else if (cmax == g)
            {
                hue = (60 * ((b - r) / diff) + 120) % 360;
                if (hue < 0) hue += 360;
            }
            else if (cmax == b)
            {
                hue = (60 * ((r - g) / diff) + 240) % 360;
                if (hue < 0) hue += 360;
            }
            if (cmax == 0)
            {
                saturation = 0;
            }
            else
            {
                saturation = (diff / cmax) * 100;
            }
            value = cmax * 100;

            tbrHue.Value = (int)hue;
            tbrSaturation.Value = (int)saturation;
            tbrValue.Value = (int)value;
        }

        private void HSVtoRGB()
        {
            double H = hue;
            double V = value;
            double S = saturation;

            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - (S/100));
                double qv = V * (1 - (S/100) * f);
                double tv = V * (1 - (S/100) * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                   
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    default:
                        R = G = B = V; 
                        break;
                }
            }
            red = Clamp((int)(R * 255.0));
            green = Clamp((int)(G * 255.0));
            blue = Clamp((int)(B * 255.0));

            tbrRed.Value = red;
            tbrGreen.Value = green;
            tbrBlue.Value = blue;
        }
        private int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        private void tbrHue_ValueChanged(object sender, EventArgs e)
        {
            hue = tbrHue.Value;
            lblHue.Text = tbrHue.Value.ToString();
        }

        private void tbrSaturation_ValueChanged(object sender, EventArgs e)
        {
            saturation = tbrSaturation.Value;
            lblSaturation.Text = tbrSaturation.Value.ToString();
        }

        private void tbrValue_ValueChanged(object sender, EventArgs e)
        {
            value = tbrValue.Value;
            lblValue.Text = tbrValue.Value.ToString();
        }
        private void tbrHue_Scroll(object sender, EventArgs e)
        {
            HSVtoRGB();
        }

        private void tbrSaturation_Scroll(object sender, EventArgs e)
        {
            HSVtoRGB();
        }

        private void tbrValue_Scroll(object sender, EventArgs e)
        {
            HSVtoRGB();
        }
    }
}
