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
    public partial class Calculator : Form
    {
        Engine CalcEngine;

        public Calculator()
        {
            InitializeComponent();

            CalcEngine = new Engine(0, 0, "normal", "");
        }

        private bool check_opr()
        {
            if (CalcEngine.get_number_operator() == "")
            {
                return true;
            }

            return false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tbx_Output.Clear();
            CalcEngine.set_number1(0);
            CalcEngine.set_number2(0);
            CalcEngine.set_operator("");
            CalcEngine.set_number_system("normal");
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            tbx_Output.Text += b.Text;
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (!check_opr())
                return;

            CalcEngine.set_operator(b.Text);
            CalcEngine.set_number1(double.Parse(tbx_Output.Text));
            tbx_Output.Clear();
        }

        private void btn_komma_Click(object sender, EventArgs e)
        {
            tbx_Output.Text += ",";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (check_opr())
                return;

            CalcEngine.set_number2(double.Parse(tbx_Output.Text));

            tbx_Output.Text = CalcEngine.calculate().ToString();

            CalcEngine.set_operator("");
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            CalcEngine.set_number_system("normal");
        }

        private void btn_Hex_Click(object sender, EventArgs e)
        {
            CalcEngine.set_number_system("hex");
        }

        private void btn_Binary_Click(object sender, EventArgs e)
        {
            CalcEngine.set_number_system("binary");
        }
    }
}
