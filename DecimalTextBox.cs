using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behaviour_Editor
{
    public partial class DecimalTextBox : UserControl
    {
        public DecimalTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Reject if not digit or '.' or '-'
            if(!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            else
            {
                // Change symbol of value when '-' is pressed
                if (e.KeyChar == '-')
                {
                    e.Handled = true;

                    if (textBox1.Text.Length != 0 || textBox1.Text != string.Empty)
                    {
                        decimal result;
                        if (decimal.TryParse(textBox1.Text, out result))
                        {
                            result *= -1;
                            textBox1.Text = result.ToString();
                        }
                    }
                    else
                    {
                        textBox1.Text = "-";
                    }

                    // Put caret at end of text
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.SelectionLength = 0;
                }
                else
                if (e.KeyChar == '.')
                {
                    // Reject if '.' is duplicated
                    if (textBox1.Text.IndexOf('.') != -1)
                    {
                        e.Handled = true;
                    }
                    // Put 0 in front if '.' is at beginning
                    else
                    {
                        if(textBox1.SelectionStart == 0)
                        {
                            e.Handled = true;
                            textBox1.Text = "0." + textBox1.Text;

                            // Put caret at end of text
                            textBox1.SelectionStart = textBox1.Text.Length;
                            textBox1.SelectionLength = 0;
                        }
                    }
                }
            }
        }
    }
}
