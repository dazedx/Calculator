using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Engine
    {
        /*
         * =================
         * Private Variables
         * =================
         */

        private string number_system;
        private string number_operator;
        private double number1;
        private double number2;

        /*
         * ===========
         * Constructor
         * ===========
         */

        public Engine(double number1, double number2, string number_system, string number_operator)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number_system = number_system;
            this.number_operator = number_operator;
        }


        /*
         * ================
         * Public Functions 
         * ================
         */

        public string get_number_system()
        {
            return number_system;
        }

        public string get_number_operator()
        {
            return number_operator;
        }

        public double get_number1()
        {
            return number1;
        }

        public double get_number2()
        {
            return number2;
        }

        public void set_number1(double number)
        {
            this.number1 = number;
        }

        public void set_number2(double number)
        {
            this.number2 = number;
        }

        public void set_operator(string opr)
        {
            this.number_operator = opr;
        }

        public void set_number_system(string number_system)
        {
            this.number_system = number_system;
        }

        public double calculate()
        {
            if (get_number_system() == "normal")
            {
                switch (get_number_operator())
                {
                    case "+":
                        {
                            return get_number1() + get_number2();
                        }

                    case "-":
                        {
                            return get_number1() - get_number2();
                        }

                    case "/":
                        {
                            return get_number1() / get_number2();
                        }
                    case "*":
                        {
                            return get_number1() * get_number2();
                        }
                }
            }

            return double.NaN;
        }
    }
}
