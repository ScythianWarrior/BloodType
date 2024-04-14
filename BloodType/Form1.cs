using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodType
{
    public partial class Form1 : Form
    {
        int mother;
        int father;
        string result = "";

        public Form1()
        {
            InitializeComponent();
        }

        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                father = 1;
            }
            else if (radioButton2.Checked == true)
            {
                father = 2;
            }
            else if (radioButton3.Checked == true)
            {
                father = 3;
            }
            else if (radioButton4.Checked == true)
            {
                father = 4;
            }

            if (radioButton5.Checked == true)
            {
                mother = 1;
            }
            else if (radioButton6.Checked == true)
            {
                mother = 2;
            }
            else if (radioButton7.Checked == true)
            {
                mother = 3;
            }
            else if (radioButton8.Checked == true)
            {
                mother = 4;
            }




            if(mother == 1 && father == 1)
            {
                result = "I - 100%";
            }
            else if(mother == 1 && father == 2 || mother == 2 && father == 1)
            {
                result = "I - 50%, II - 50%";
            }
            else if (mother == 1 && father == 3 || mother == 3 && father == 1)
            {
                result = "I - 50%, III - 50%";
            }
            else if (mother == 1 && father == 4 || mother == 4 && father == 1)
            {
                result = "II - 50%, III - 50%";
            }
            else if (mother == 2 && father == 3 || mother == 3 && father == 2)
            {
                result = "I -25%, II - 25%, III - 25%, IV - 25%";
            }
            else if (mother == 2 && father == 4 || mother == 4 && father == 2)
            {
                result = "II - 50%, III - 25%, IV - 25%";
            }
            else if (mother == 3 && father == 4 || mother == 4 && father == 3)
            {
                result = "II - 50%, III - 25%, IV - 25%";
            }
            else if (mother == 2 && father == 2)
            {
                result = "I - 50%, II - 50%";
            }
            else if (mother == 3 && father == 3)
            {
                result = "I - 50%, III - 50%";
            }
            else if (mother == 4 && father == 4)
            {
                result = "II - 25%, III - 25%, IV - 50%";
            }



            Form2 form2 = new Form2();
            form2.bloodTypeResult.Text = result;
            form2.Show();
            
           
        }

        

        private void imgsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }
    }

    

    
}
