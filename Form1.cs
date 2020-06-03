/**
@author Mohammed Khalid, Yad Ghazi, Ahin Omer, Ali Swar.
@version 1.0
@mainpage Number System
@section_sec Introduction to our Number System program
@details It converts a decimal number to other types of numeral system (binary,octal,hexa)
@param Every value that you are getting into computer memory has a defined number system.

 

*/



// needed library
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------


namespace test123
{
    public partial class Form1 : Form // it is the main block
    {
        public Form1() // this block brings items from Form1 (Design)
        {
            InitializeComponent(); // it defines the foreign functions (Form1)
        }

        private void label1_Click(object sender, EventArgs e) // it brings out the label in the interface
        {

        }

        private void button2_Click(object sender, EventArgs e) // when you click the octal button, the programm doing the following commands
        {

            int number = int.Parse(textBox1.Text); // it stores what the user types in the (textbox1) in number variable as an integer number 
            string Base = Convert.ToString(number, 8); // convert the value of the number variable to string based on octal number and stored in base variable 
            textBox2.Text = Base; // it changes th textbox2 value to base value(it shows the base number in textbox2)
            if (Base == "12")
               
            {
                textBox3.Text = "True";
                
            }
            else { textBox3.Text = "False"; }
        }

        private void button1_Click(object sender, EventArgs e) // when you click the binary button, the programm doing the following commands
        {

            int number = int.Parse(textBox1.Text); // it stores what the user types in the (textbox1) in number variable as an integer number 
            string Base = Convert.ToString(number, 2); // convert the value of the number variable to string based on binary number and stored in base variable 
            textBox2.Text = Base; // it changes th textbox2 value to base value(it shows the base number in textbox2)


        }

        private void button3_Click(object sender, EventArgs e) // when you click the hexa button, the programm doing the following commands
        {
            int number = int.Parse(textBox1.Text); // it stores what the user types in the (textbox1) in number variable as an integer number 
            string Base = Convert.ToString(number, 16); // convert the value of the number variable to string based on hexa number and stored in base variable 
            textBox2.Text = Base; // it changes th textbox2 value to base value(it shows the base number in textbox2)
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // it brings out the textbox1 in the interface
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // it brings out the textbox2 in the interface
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
