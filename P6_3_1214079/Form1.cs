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

namespace P6_3_1214079
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka, "Inputan hanya boleh Angka!");
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            {

                if (txtAngka2.Text == "")
                {

                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "Textbox Huruf tidak boleh kosong!");
                    epCorrect.SetError(txtAngka2, "");
                }
                else
                {
                    if ((txtAngka2.Text).All(Char.IsNumber))
                    {
                        epWrong.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                        epWarning.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                    }
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(txtAngka1.Text);
            int Angka2 = int.Parse(txtAngka2.Text);

            if (txtAngka2.Text == "")
            {

                epWrong.SetError(txtAngka2, "");
                epWarning.SetError(txtAngka2, "Textbox tidak boleh kosong!");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka2.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
            }
            if (Angka1 > Angka2)
            {
                epWrong.SetError(txtAngka1, "");
                epWarning.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "Betul!");

                epWrong.SetError(txtAngka2, "");
                epWarning.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "Betul!");
            }
            else
            {
                epWrong.SetError(txtAngka1, "Salah");
                epWarning.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");

                epWrong.SetError(txtAngka2, "Salah");
                epWarning.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
