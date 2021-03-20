using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StackCalculator
{
    public partial class Form1 : Form
    {
        IntStack theStack = new IntStack(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            process(txtData.Text);
            txtTopStack.Text = theStack.Peek().ToString();
            txtStackDisplay.Text = theStack.Print();
        }

        private void process(string input)
        {
            int rightInt, leftInt, storeInt;
            switch (input)
            {
                case "+": //addition
                    theStack.Push(theStack.Pop() + theStack.Pop());
                    break;
                case "-": //subtraction
                       rightInt = theStack.Pop();
                       leftInt = theStack.Pop();
                     theStack.Push(leftInt - rightInt); //second integer entered - first integer entered
                    break;
                case "*": //multiplication
                    theStack.Push(theStack.Pop() * theStack.Pop());
                    break;
                case "/": //division
                    theStack.Push(theStack.Pop() / theStack.Pop());
                    break;
                case "<>": //exchange
                    theStack.exchange();
                    break;
                default:
                    theStack.Push(Convert.ToInt32(input)); //convert intputs to integers
                    break;
            }            
        }
    }
}