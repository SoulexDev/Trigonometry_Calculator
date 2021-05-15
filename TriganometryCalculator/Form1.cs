using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriganometryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((Input1.Text.Length == 0 || Input2.Text.Length == 0))
            {

                ErrorMessage.Visible = true;
                _ = ResetVisibility();
                return;
            }
            try
            {
                float input1 = float.Parse(Input1.Text);
                float input2 = float.Parse(Input2.Text);
                if (SinCalc.Checked)
                {
                    Answer1.Text = "X:" + SOHCAHTOAcalculations.SOH(input1, input2).X.ToString();
                    Answer2.Text = "Y:" + SOHCAHTOAcalculations.SOH(input1, input2).Y.ToString();
                }
                else if (CosCalc.Checked)
                {
                    Answer1.Text = "X:" + SOHCAHTOAcalculations.CAH(input1, input2).X.ToString();
                    Answer2.Text = "Y:" + SOHCAHTOAcalculations.CAH(input1, input2).Y.ToString();
                }
                else if (TanCalc.Checked)
                {
                    Answer1.Text = "X:" + SOHCAHTOAcalculations.TOA(input1, input2).X.ToString();
                    Answer2.Text = "Y:" + SOHCAHTOAcalculations.TOA(input1, input2).Y.ToString();
                }
            }
            catch
            {
                ErrorMessage.Visible = true;
                _ = ResetVisibility();
            }
        }
        public async Task ResetVisibility()
        {
            await Task.Delay(1300);
            ErrorMessage.Visible = false;
        }
        private void SinCalc_CheckedChanged(object sender, EventArgs e)
        {
            InputNumberOne.Text = "Opposite";
            InputNumberTwo.Text = "Hypotenuse";
        }

        private void CosCalc_CheckedChanged(object sender, EventArgs e)
        {
            InputNumberOne.Text = "Adjacent";
            InputNumberTwo.Text = "Hypotenuse";
        }

        private void TanCalc_CheckedChanged(object sender, EventArgs e)
        {
            InputNumberOne.Text = "Opposite";
            InputNumberTwo.Text = "Adjacent";
        }

        private void Input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Input2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    public class SOHCAHTOAcalculations
    {
        public static Angles SOH(float opposite, float hypotenuse)
        {
            double x = Math.Asin(opposite / hypotenuse) * 180/Math.PI;
            double y = 180 - (x + 90);
            return new Angles
            {
                X = x,
                Y = y
            };
        }
        public static Angles CAH(float adjacent, float hypotenuse)
        {
            double x = Math.Acos(adjacent / hypotenuse) * 180 / Math.PI;
            double y = 180 - (x + 90);
            return new Angles
            {
                X = x,
                Y = y
            };
        }
        public static Angles TOA(float opposite, float adjacent)
        {
            double x =  Math.Atan(opposite / adjacent) * 180 / Math.PI;
            double y = 180 - (x + 90);
            return new Angles
            {
                X = x,
                Y = y
            };
        }
    }
    public class Angles
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}