using System;


namespace MathLibrary
{
    public class Operations
    {
        private double first;
        private double second;
        private double one;
        private char oper;
        private string line;
        private bool flag;
        public Operations(double first,double second,char oper)
        {
            if (char.IsWhiteSpace(oper))
            {
                throw new Exception("No sign");

            }

            this.first = first;
            this.second = second;
            this.oper = oper;
            flag = true;
            Set();
        }

        public Operations(double one,char oper)
        {

            this.one = one;
            this.oper = oper;
            flag = false;
            Set();
        }

        private void Set()
        {
            switch (oper)
            {
                case '+':
                    Sum();
                    break;

                case '-':
                    Substraction();
                    break;

                case '*':
                    Multiplication();
                    break;

                case '/':
                    Divide();
                    break;

                case 's':
                    Sin();
                    break;

                case 'c':
                    Cos();
                    break;

                case 't':
                    Tangens();
                    break;

                case 'o':
                    Cotangens();
                    break;


                default:
                    break;
            }


        }
        private void Sum()
        {
           line= (first + second).ToString();
        }
        private void Substraction()
        {
          line=  (first - second).ToString();
        }
        private void Multiplication()
        {
            line= (first * second).ToString();

        }
        private double Divide()
        {
            return first / second;
        }

       private void  Tangens()
        {
            if (flag)
            {
                line = "First Tan " + Math.Tan(first).ToString() + "second Tan "
               + Math.Tan(second).ToString();
            }
            else
            {
                line = Math.Tan(one).ToString();
            }
            //  var array = new[] { Math.Tan(first), Math.Tan(second) };
           
        }
        private void Cotangens()
        {
            if (flag)
            {
                //  var array = new[] { Math.Tan(first), Math.Tan(second) };
                line = "First Ctg " + (1 / Math.Tan(first)).ToString() + "second Ctg "
                     + (1 / Math.Tan(second)).ToString();
            }
            else
            {
                line = (1 / Math.Tan(one)).ToString();
            }
           
        }
        private void Sin()
        {
            if (flag)
            {
                //  var array = new[] { Math.Tan(first), Math.Tan(second) };
                line = "First Sin " + Math.Sin(first).ToString() + "second Sin "
                    + Math.Sin(second).ToString();
            }
            else
            {
                line = Math.Sin(one).ToString();
            }
           
        }

        private void Cos()
        {
            if (flag)
            {
                //  var array = new[] { Math.Tan(first), Math.Tan(second) };
                line = "First Cos " + Math.Cos(first).ToString() + "second Cos "
                     + Math.Cos(second).ToString();
            }
            else
            {
                line = Math.Cos(one).ToString();
            }
            
        }

        
     
        public override string ToString()
        {
            return line;
        }

    }
}
