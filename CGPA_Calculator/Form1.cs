using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CGPA_Calculator
{
    public partial class Form1 : Form
    {
        double gpa, g, m;
        int total_crHrs;
        double total_qp;

        public Form1()
        {
            InitializeComponent();

        }

        private void cgp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void c1_TextChanged(object sender, EventArgs e)
        {


        }

        private void h1_TextChanged(object sender, EventArgs e)
        {
            if ((h1.Text != "") && (c1.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c1.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h1.Text);
                    cgp1.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp1.Text);
            }

        }

        private void h2_TextChanged(object sender, EventArgs e)
        {
            if ((h2.Text != "") && (c2.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c2.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h2.Text);
                    cgp2.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp2.Text);
            }
        }

        private void h3_TextChanged(object sender, EventArgs e)
        {
            if ((h3.Text != "") && (c3.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c3.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h3.Text);
                    cgp3.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp3.Text);
            }
        }

        private void h4_TextChanged(object sender, EventArgs e)
        {
            if ((h4.Text != "") && (c4.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c4.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h4.Text);
                    cgp4.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp4.Text);
            }

        }

        private void h5_TextChanged(object sender, EventArgs e)
        {
            if ((h5.Text != "") && (c5.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c5.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h5.Text);
                    cgp5.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp5.Text);
            }

        }

        private void h6_TextChanged(object sender, EventArgs e)
        {
            if ((h6.Text != "") && (c6.Text != ""))
            {
                total_crHrs += int.Parse(h1.Text);
                m = double.Parse(c6.Text);
                if (m >= 80)
                {
                    gpa = 4 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }

                if ((m >= 75) && (m < 80))
                {
                    gpa = 3.5 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }
                if ((m >= 70) && (m < 75))
                {
                    gpa = 3.0 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }

                if ((m >= 65) && (m < 70))
                {
                    gpa = 2.5 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }
                if ((m >= 60) && (m < 65))
                {
                    gpa = 2.0 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }
                if ((m >= 55) && (m < 60))
                {
                    gpa = 1.5 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }


                if ((m >= 50) && (m < 55))
                {
                    gpa = 1.0 * int.Parse(h6.Text);
                    cgp6.Text = gpa.ToString();
                }
                total_qp += double.Parse(cgp6.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] crHrs=new int[]

            //double sum_gpa,sum_qp,res;
            //sum_gpa = (double.Parse(cgp1.Text) + double.Parse(cgp2.Text) + double.Parse(cgp3.Text) + double.Parse(cgp4.Text) + double.Parse(cgp5.Text) + double.Parse(cgp6.Text));
            //sum_qp = (int.Parse(h1.Text) + int.Parse(h2.Text) + int.Parse(h3.Text) + int.Parse(h4.Text) + int.Parse(h5.Text) + int.Parse(h6.Text));
            double res = (total_qp / total_crHrs);
            final.Text = res.ToString();
            //if (double.Parse(final.Text) <= 1)
            //{
            //    com.Text = "You CGPA is Poor";
            //}
            //if (double.Parse(final.Text) >= 2 && (double.Parse(final.Text) <= 3))
            //{
            //    com.Text = "You Got Average CGPA";
            //}
            //if (double.Parse(final.Text) >= 3 && (double.Parse(final.Text) < 4))
            //{
            //    com.Text = "You CGPA is Good";
            //}
            //if (double.Parse(final.Text) >=4)
            //{
            //    com.Text = "You Got Excellent GPA";
            //}



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cgp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgp4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgp5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgp6_TextChanged(object sender, EventArgs e)
        {

        }

        private void c2_TextChanged(object sender, EventArgs e)
        {

        }

        private void c3_TextChanged(object sender, EventArgs e)
        {

        }

        private void c4_TextChanged(object sender, EventArgs e)
        {

        }

        private void c5_TextChanged(object sender, EventArgs e)
        {

        }

        private void c6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

