using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_grupo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBoxCelsius.Text);

            double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

            textBoxFahrenheit.Text = "(" + celsius +  " * 9.0 / 5.0) + 32.0 =" + fahrenheit.ToString();
        }
    }
}
