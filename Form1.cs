using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
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

        private void FehrToCels_Click(object sender, EventArgs e)
        {
            try
            {
                double fehr = Convert.ToDouble(FahrenheitTextBox.Text);

                double cels = (fehr - 32) * 5 / 9;

                CelsiumTextBox.Text = Math.Round(cels).ToString();
            }
            catch (Exception ex) 
            {
                CelsiumTextBox.Text = ex.Message;
            }
           
        }

        private void CelsToFehr_Click(object sender, EventArgs e)
        {
            try
            {
                double cels = Convert.ToDouble(CelsiumTextBox.Text);

                double fehr = (cels * 9 / 5) + 32;

                FahrenheitTextBox.Text = Math.Round(fehr).ToString();
            }
            catch (Exception ex) 
            {
                FahrenheitTextBox.Text = ex.Message;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
