using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {
        int convertChoice; //stores conversion choice
        double value; //stores value to be converted

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result;
                convertChoice = Convert.ToInt16(convertInput.Text); //records conversion choice
                value = Convert.ToDouble(valueInput.Text); //records value

                switch (convertChoice) //triggers method based on conversion choice
                {
                    case 1:
                        result = InchesToCm(value);
                        outputLabel.Text = $"{value} inches = {result} centimetres";
                        break;
                    case 2:
                        result = FeetToCm(value);
                        outputLabel.Text = $"{value} feet = {result} centimetres";
                        break;
                    case 3:
                        result = YardsToMetres(value);
                        outputLabel.Text = $"{value} yards = {result} metres";
                        break;
                    case 4:
                        result = MilesToKm(value);
                        outputLabel.Text = $"{value} miles = {result} kilometres";
                        break;
                    default: //if choice is invalid
                        outputLabel.Text = "Conversion Choice Invalid";
                        break;
                }
            }
            catch //shows error message if input is invalid
            {
                outputLabel.Text = "Choice or value was invalid";
            }
        }

        public double InchesToCm(double x)
        {
            double answer;

            answer = x * 2.54;
            return answer;
        }

        public double FeetToCm(double x)
        {
            double answer;

            answer = x * 30.48;
            return answer;
        }

        public double YardsToMetres(double x)
        {
            double answer;

            answer = x * 0.91;
            return answer;
        }

        public double MilesToKm(double x)
        {
            double answer;

            answer = x * 1.6;
            return answer;
        }
    }
}
