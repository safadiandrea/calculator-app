using System.Reflection.Emit;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        double num1;
        double num2;
        double result = 0;
        string operand;

        public Form1()
        {
            InitializeComponent();
            // Initialize the form and its components

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {

            Button button = sender as Button; // tells program this object is a button
            string number = button.Text;

            AppendNumber(number);
        }

        private void AppendNumber(string number)
        {
            if (textBox1.Text == "0" && number == "0")
            {
                return; // Do nothing if both are zero
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = number; // Replace 0 with the number clicked
            }
            else
            {
                textBox1.Text += number; // Append the number to the existing text
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // method for percentages
        private void pcentButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num2))
            {
                Convert.ToInt32(num1);
                num2 = num1 * (num2 / 100);
                textBox1.Text = num2.ToString();
            }
        }

        private void clrallButton_Click(object sender, EventArgs e)
        {
            // delete memory 
            if (textBox1.Text.Length > 0)
            {
                textBox1.Clear();
                label1.Text = "";
            }
        }

        // clears text
        private void clrButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                // Clear the text box
                textBox1.Clear();
            }
        }

        // method for deleting last number in the line
        private void delButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("error"))
            {
                textBox1.Clear();
                label1.Text = "";
            }

            else if (textBox1.Text.Length > 0)
            {
                // Remove the last character from the text box
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        // method for division
        private void divButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                operand = "/";
                label1.Text = textBox1.Text + operand;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid operation. Clear and try again.");
            }
        }

        // method for multiplication
        private void multButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                operand = "*";
                label1.Text = textBox1.Text + operand;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid operation. Clear and try again.");
            }
        }

        // method for addition
        private void addButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                operand = "+";
                label1.Text = textBox1.Text + operand;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid operation. Clear and try again.");
            }
        }

        // method for pressing equals
        private void eqlButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num2))
            {
                switch (operand)
                {
                    // addition
                    case "+":
                        result = num1 + num2;
                        break;
                    // subtraction
                    case "-":
                        result = num1 - num2;
                        break;
                    // multiplication
                    case "*":
                        result = num1 * num2;
                        break;
                    // division
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            textBox1.Text = "error";
                            return;
                        }
                        break;

                    default:
                        return;

                }

                textBox1.Text = result.ToString();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid operation. Clear and try again.");
            }
        }

        private void memC_Click(object sender, EventArgs e)
        {

        }

        // method for subtraction
        private void minButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                operand = "-";
                label1.Text = textBox1.Text + operand;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid operation. Clear and try again.");
            }
        }

        // method for reciprocals
        private void recipButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                if (textBox1.Text != "0")
                {
                    double reciprocal = 1 / num1;
                    textBox1.Text = reciprocal.ToString();
                }
                else
                {
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // method for creating decimals
        private void decmlButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }


        // method for changing numbers to positive/negative
        private void posnegButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        // method for squaring numbers
        private void sqrButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse((string)textBox1.Text, out num1))
            {
                if (textBox1.Text != "0")
                {
                    num1 = num1 * num1;
                    textBox1.Text = num1.ToString("0.##");
                }
                else
                {
                    return;
                }
            }
        }

        // method for square roots
        private void rootButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1))
            {
                num1 = Math.Sqrt(num1);
                textBox1.Text = num1.ToString("0.##");
            }
        }
    }
}
