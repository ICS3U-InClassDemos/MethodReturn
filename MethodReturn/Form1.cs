using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MethodReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            ///1.  Get values for question 1 and call the Add method. 
            /// Accept the returned value and then display it.
            /// 
            /// Sample input and output:
            /// 
            /// Input: 4, 5
            /// 4 + 5 = 9
            /// 
            /// Input: 6, 1
            /// 6 + 1 = 7;

            int num1 = Convert.ToInt16(q1Num1Input.Text);
            int num2 = Convert.ToInt16(q1Num2Input.Text);          

            int answer = Add(num1, num2);
            q1Output.Text = $"The answer is {answer}";

            /// 2.  Get values for question 2 and call the Area method. 
            /// Accept the returned value and then display it.
            /// 
            /// Sample input and output:
            /// 
            /// Input: 4, 5
            /// The area is 20 units squared
            /// 
            /// Input: 6, 2
            /// The area is 18 units squared
            int s1 = Convert.ToInt16(widthInput.Text);
            int s2 = Convert.ToInt16(lengthInput.Text);

            int result = Area(s1, s2);
            q2Output.Text = $"the area is {result}";


            /// 3.  Get a value for question 3 and call the PrintPrice 
            /// method. Accept the returned value and then display it.
            /// 
            /// Sample input and output:
            /// 
            /// Input: 5
            /// The total price is $5.00
            /// 
            /// Input: 75
            /// The total price is $48.75
            /// 
            /// Input: 200
            /// The total price is $100.00
            int copies = Convert.ToInt32(copiesInput.Text);

            double totalPrice = PrintPrice(copies);
            q3Output.Text = $"The price for {copies} is {totalPrice.ToString("C")}";
        }

        /// 1. Create a method called Add, that accepts 2 int 
        /// parameters, (x and y), adds them together, and then 
        /// returns the result back to the method call.       

        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;      
            
        }
        
        /// <summary>
        /// Calculates area of a rectangle
        /// </summary>
        /// <param name="length">length of longest side</param>
        /// <param name="width">length of shortest side</param>
        /// <returns>area in squared units</returns>
        public int Area(int length, int width)
        {
            int area = length * width;
            return area;
        }


        /// 3. Create a method called PrintPrice, that accepts 1 
        /// int parameter, (prints), uses it to determine the 
        /// price for the customer based on the following
        /// pricing structure, and returns the result back to the 
        /// method call.
        ///        
        /// 0 - 10 prints:  $1.00/print
        /// 11 - 50 prints:  $0.75/print
        /// 51 - 100 prints:  $0.65/print
        /// 101 or over:  $0.50/print

        public double PrintPrice(int prints)
        {
            double price = 0;

            if(prints <=10)
            {
                price = prints * 1;
            }
            else if (prints <=50)
            {
                price = prints * .75;
            }
            else if (prints <= 100)
            {
                price = prints * .75;
            }
            else
            {
                price = prints * .50;
            }

            return price;
        }

    }
}