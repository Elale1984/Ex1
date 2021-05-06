using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//The purpose of this program is to create a windows form application that will ask for the 
//first and last name of the user, determine whether or not they are new to C#, and then display
//a message at the bottom when the button is clicked containing the name entered and a message that 
//is appropriate for the user being new to C# or not.

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is the click event for the submit button. When this button is clicked, 
        //a message will appear at the bottom of the screen containing a welcome message
        //as well as the first and last name.

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            String fName = tb_FN.Text;
            String lName = tb_LN.Text;

            //Test if the checkbox was selected or not. Mesage will be appropriate to response.
            if (cb_New.Checked)
            {
                
                lb_Mess.Text = "Welcome To C# " + fName + " " + lName + "! It's Easy!";
            }
            else
            {
                lb_Mess.Text = "Welcome Back " + fName + " " + lName + "! Lets pick up where we left " +
                    "off ";
            }
            
        }
    }
}
