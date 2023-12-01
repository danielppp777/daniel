using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
         
        { 
            {
                
                Console.WriteLine("Въведете елементите на масива, разделени с интервал:");
                string input = Console.ReadLine();
                int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

                
                Array.Sort(numbers);

            
                double median;
                if (numbers.Length % 2 == 0)
                {
                   
                    int middle1 = numbers.Length / 2 - 1;
                    int middle2 = numbers.Length / 2;
                    median = (numbers[middle1] + numbers[middle2]) / 2.0;
                }
                else
                {
                    
                    int middle = numbers.Length / 2;
                    median = numbers[middle];
                }

                
                Console.WriteLine($"Медиана: {median}");
            }
        }

    }
}

