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
    public partial class Vector2TextBox : UserControl
    {

        public event EventHandler X_Validated;
        public event EventHandler Y_Validated;

        public Vector2TextBox()
        {
            InitializeComponent();

            this.Load += Vector2TextBox_Load;
        }

        private void Vector2TextBox_Load(object sender, EventArgs e)
        {
            decTxtBox_X.Validated += DecTxtBox_X_Validated;
            decTxtBox_Y.Validated += DecTxtBox_Y_Validated;
            X_Validated = null;
            Y_Validated = null;
        }

        private void DecTxtBox_X_Validated(object sender, EventArgs e)
        {
            //

            if (X_Validated != null)
            {
                X_Validated(sender, e);
            }
        }

        private void DecTxtBox_Y_Validated(object sender, EventArgs e)
        {
            if(Y_Validated != null)
            {
                Y_Validated(sender, e);
            }
        }

        public void Set_X(string _x)
        {
            decTxtBox_X.textBox1.Text = _x;
        }

        public void Set_Y(string _y)
        {
            decTxtBox_Y.textBox1.Text = _y;
        }

        public void SetText(string _x, string _y)
        {
            decTxtBox_X.textBox1.Text = _x;
            decTxtBox_Y.textBox1.Text = _y;
        }

        public void SetVector2(Vector2 _vec2)
        {
            decTxtBox_X.textBox1.Text = _vec2.x.ToString();
            decTxtBox_Y.textBox1.Text = _vec2.y.ToString();
        }
    }
}
