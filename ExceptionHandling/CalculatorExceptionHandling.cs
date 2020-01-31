using System;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
    class Calculator
    {
        public int Add(int operand1, int operand2)
            {
            int result=0;
            try
            {
                if (operand1 != default(int))
                    throw new TypeException("The type is not int");
                
                else
                    result = operand1 + operand2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TypeException e)
            {

                Console.WriteLine(e.Message);
            }
            return result;
        }
        public int Subtract(int operand1, int operand2)
        {
            int result = 0;
            try
            {
                if (operand1 != default(int))
                    throw new TypeException("The type is not int");
                else
                    result=operand1 - operand2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TypeException e)
            {

                Console.WriteLine(e.Message);
            }
            return result;
        }
            public int Multiply(int operand1, int operand2)
            {
                int result = 0;
                try
                {
                if (operand1 == 0)
                    throw new NumberFormatException(operand1);
                else if(operand2==0)
                    throw new MultiplyByZeroException();
                else
                    result = operand1 * operand2;

                }
                catch (MultiplyByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NumberFormatException e)
            {

                Console.WriteLine(e.Message);
            }
            return result;
            }
            public double Divide(double operand1, double operand2)
            {
                double result = 0;
                try
                {
                if(operand1==0)
                throw new NumberFormatException(operand1);
                else
                result = operand1 / operand2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               catch (ArithmeticException e)
                {
                Console.WriteLine(e.Message);
            }
            catch (NumberFormatException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
                {
                    Console.WriteLine("Finally");
                }
                return result;
            }


        }


    internal class TypeException : Exception
    {
        public TypeException(string message) : base(message)
        {
            Console.WriteLine("The Type mentioned should be int");
        }

    }


    internal class NumberFormatException : Exception
    {
        public NumberFormatException(double operand1) : base()
        {
            if (operand1.Equals(""))
                Console.WriteLine("");
            else
                Console.WriteLine("");
        }
    }

    public class MultiplyByZeroException : Exception
        {
            public MultiplyByZeroException() : base()
            {
            Console.WriteLine("The Multiply By Zero Exception");
        }
            
        }
    }

