using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanieliFirstQuestion
{
    public partial class Form1 : Form
    {
        string equation = "";
        string oper = ""; //Operation sign 

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (displayText.Text == "0")
                displayText.Text = "0";

            if (button.Text == ".")
            {
                if (!displayText.Text.Contains("."))
                    displayText.Text = displayText.Text + button.Text;
            }
            else
            {
                displayText.Text = displayText.Text + button.Text;
                equation += displayText.Text;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //C button 
            displayText.Text = "";
            equation = "";

        }

        private void Operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            oper = button.Text;

            equation += oper;

            displayText.Text = "";
        }
      

        private void button19_Click(object sender, EventArgs e)
        {
            double solution = Convert.ToDouble(new DataTable().Compute(equation, null));
            displayText.Text = Convert.ToString(solution);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
