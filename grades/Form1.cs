using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    public partial class Form1 : Form
    {
        private string Name;
        //holds text or non numbers        
        private Single Score;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           /* Score = Convert.ToSingle(txtGrade.Text);
            Name = txtName.Text;
            if
              (Convert.ToSingle(txtGrade.Text) < 50)
            {
                lblGrade.Text = "Fail"; lbxGrade.Items.Add(Name + " " + txtGrade.Text + " Fail");
            }
            else
            {
                lblGrade.Text = "Pass"; lbxGrade.Items.Add(Name + " " + txtGrade.Text + " Pass");
            }*/
            {
                if (txtGrade.Text == "")
                {
                    lblGrade.Text = "Nothing Entered, Nothing Gained";
                    return;
                }
                //Move the grade to the Score
                Score = Convert.ToSingle(txtGrade.Text);
                //Move the Name to the Name
                Name = txtName.Text;
                //test to check if its true
                if (Score < 0)
                {
                    txtGrade.Text = "";
                    txtName.Text = "";
                    lblGrade.Text = Score + " " + Name + " Fail";
                    lbxGrade.Items.Add(Score + " " + Name + " Fail");
                }
                if (Score <= 50)
                {
                    lblGrade.Text = Score + " " + Name + " Fail";
                    lbxGrade.Items.Add(Score + " " + Name + " Fail");
                }
                else if (Score <= 60)
                {
                    lblGrade.Text = Score + " " + Name + " C";
                    lbxGrade.Items.Add(Score + " " + Name + " C");
                }
                else if (Score <= 70)
                {
                    lblGrade.Text = Score + " " + Name + " B";
                    lbxGrade.Items.Add(Score + " " + Name + " B");
                }
                else if (Score <= 80)
                {
                    lblGrade.Text = Score + " " + Name + " B+";
                    lbxGrade.Items.Add(Score + " " + Name + " B+");
                }
                else if (Score <= 90)
                {
                    lblGrade.Text = Score + " " + Name + " A-";
                    lbxGrade.Items.Add(Score + " " + Name + " A-");
                }
                else if (Score <= 100)
                {
                    lblGrade.Text = Score + " " + Name + " A";
                    lbxGrade.Items.Add(Score + " " + Name + " A");
                }
                else if (Score > 100)
                {
                    lblGrade.Text = "Stop lying " + Name;
                    lbxGrade.Items.Add("Stop lying " + Name);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

