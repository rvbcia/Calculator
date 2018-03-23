using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Kalkulator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_Pressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_Pressed = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString(); //only string in result textbox
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString(); //only string in result textbox
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString(); //only string in result textbox
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString(); //only string in result textbox
                    break;

                case "^":
                    result.Text = (Math.Pow(value, Double.Parse(result.Text))).ToString(); //only string in result textbox
                    break;

                default:
                    break;

            } //end switch

            operation_Pressed = false;
        }
    }
}
