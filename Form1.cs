using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        Methods myMethod = new Methods();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPalindromeCheck_Click(object sender, EventArgs e)
        {
            if (myMethod.CheckIfPalindrome(TxtPalindromeInput.Text))
            {
                LblPalindromeOutput.Text = TxtPalindromeInput.Text + " is a palindrome";
            }
            else if (!(myMethod.CheckIfPalindrome(TxtPalindromeInput.Text)))
            {
                LblPalindromeOutput.Text = TxtPalindromeInput.Text + " is not a palindrome";
            }
            else
            {
                LblPalindromeOutput.Text = "Sorry, I could not tell if this was a palindrome!";
            }
        }
    }
}
