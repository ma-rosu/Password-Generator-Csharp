using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordMaker
{
    public partial class Form1 : Form
    {

        private const string alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string specialCharacters = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?";
        private const string numbers = "0123456789";
        private string passwordGen;
        private int passLen;
        private char randomChar;
        private int randomNum;
        private readonly Random random = new Random();



        public Form1()
        {
            InitializeComponent();
        }

         

        private void BtnGen_Click(object sender, EventArgs e)
        {
            passwordGen = "";
            int special = 0, let = 0, num = 0, i = 0;
            passLen = Convert.ToInt32(lenPassSet.Value);

            if (checkSpecial.Checked) special = 1;
            if (checkLet.Checked) let = 1;
            if (checkNum.Checked) num = 1;
            if (special == 0 && let == 0 & num == 0)
                MessageBox.Show("Please check at least one option!");
            else
            {
                while (i < passLen)
                {
                    randomNum = random.Next(0, 3);
                    switch (randomNum)
                    {
                        case 0:
                            if (let == 1)
                            {
                                randomChar = alphabets[random.Next(0, alphabets.Length)];
                                passwordGen += randomChar;
                            }
                            else
                                i--;
                            break;
                        case 1:
                            if (special == 1)
                            {
                                randomChar = specialCharacters[random.Next(0, specialCharacters.Length)];
                                passwordGen += randomChar;
                            }
                            else
                                i--;
                            break;
                        case 2:
                            if (num == 1)
                            {
                                randomChar = numbers[random.Next(0, numbers.Length)];
                                passwordGen += randomChar;
                            }
                            else
                                i--;
                            break;
                    }
                    i++;
                }
                inputPassword.Text = passwordGen;
            }

           
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inputPassword.Text);
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
