namespace Driver_s_LIcense_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //correct answers
            char[] correctansw = { 'B' , 'D', 'A', 'A', 'C' , 'A' , 'B' , 'A' , 'C' , 'D', 'B', 'C', 'D' , 'A', 'D' , 'C' , 'C', 'B', 'D', 'A' };
       
            //(WARNING:: MAHABANG IFELSE)GETTING INPUTS FROM USER
            char choice1 = char.Parse(textBox1.Text);
            char choice2 = char.Parse(textBox2.Text);
            char choice3 = char.Parse(textBox3.Text);
            char choice4 = char.Parse(textBox4.Text);
            char choice5 = char.Parse(textBox5.Text);
            char choice6 = char.Parse(textBox6.Text);
            char choice7 = char.Parse(textBox7.Text);
            char choice8 = char.Parse(textBox8.Text);
            char choice9 = char.Parse(textBox9.Text);
            char choice10 = char.Parse(textBox10.Text);
            char choice11 = char.Parse(textBox20.Text);
            char choice12 = char.Parse(textBox19.Text);
            char choice13 = char.Parse(textBox18.Text);
            char choice14 = char.Parse(textBox17.Text);
            char choice15 = char.Parse(textBox16.Text);
            char choice16 = char.Parse(textBox15.Text);
            char choice17 = char.Parse(textBox14.Text);
            char choice18 = char.Parse(textBox13.Text);
            char choice19 = char.Parse(textBox12.Text);
            char choice20 = char.Parse(textBox11.Text);


            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int score5 = 0;
            int score6 = 0;
            int score7 = 0;
            int score8 = 0;
            int score9 = 0;
            int score10 = 0;
            int score11 = 0;
            int score12 = 0;
            int score13 = 0;
            int score14 = 0;
            int score15 = 0;
            int score16 = 0;
            int score17 = 0;
            int score18 = 0;
            int score19 = 0;
            int score20 = 0;



            if (choice1 == correctansw[0])
            {
                score1 = 1;
            }
            else
            {
                score1 = 0;
            }

            if (choice2 == correctansw[1])
            {
                score2 = 1;
            }
            else
            {
                score2 = 0;
            }

            if (choice3 == correctansw[2])
            {
                score3 = 1;
            }
            else
            {
                score3 = 0;
            }

            if (choice4 == correctansw[3])
            {
                score4 = 1;
            }
            else
            {
                score4 = 0;
            }

            if (choice5 == correctansw[4])
            {
                score5 = 1;
            }
            else
            {
                score5 = 0;
            }

            if (choice6 == correctansw[5])
            {
                score6 = 1;
            }
            else
            {
                score6 = 0;
            }

            if (choice7 == correctansw[6])
            {
                score7 = 1;
            }
            else
            {
                score7 = 0;
            }

            if (choice8 == correctansw[7])
            {
                score8 = 1;
            }
            else
            {
                score8 = 0;
            }

            if (choice9 == correctansw[8])
            {
                score9 = 1;
            }
            else
            {
                score9 = 0;
            }

            if (choice10 == correctansw[9])
            {
                score10 = 1;
            }
            else
            {
                score10 = 0;
            }

            if (choice11 == correctansw[10])
            {
                score11 = 1;
            }
            else
            {
                score11 = 0;
            }

            if (choice12 == correctansw[11])
            {
                score12 = 1;
            }
            else
            {
                score12 = 0;
            }

            if (choice13 == correctansw[12])
            {
                score13 = 1;
            }
            else
            {
                score13 = 0;
            }

            if (choice14 == correctansw[13])
            {
                score14 = 1;
            }
            else
            {
                score14 = 0;
            }

            if (choice15 == correctansw[14])
            {
                score15 = 1;
            }
            else
            {
                score15 = 0;
            }

            if (choice16 == correctansw[15])
            {
                score16 = 1;
            }
            else
            {
                score16 = 0;
            }

            if (choice17 == correctansw[16])
            {
                score17 = 1;
            }
            else
            {
                score17 = 0;
            }

            if (choice18 == correctansw[17])
            {
                score18 = 1;
            }
            else
            {
                score18 = 0;
            }

            if (choice19 == correctansw[18])
            {
                score19 = 1;
            }
            else
            {
                score19 = 0;
            }

            if (choice20 == correctansw[19])
            {
                score20 = 1;
            }
            else
            {
                score20 = 0;
            }

            //TO GET THE TOTAL SCORE AND PRINT IT
            double totalscore = (score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10 + score11
                                    + score12 + score13 + score14 + score15 + score16 + score17 + score18 + score19 + score20);

            label24.Text = totalscore.ToString();

            //GETTING THE REMARKS (PASSED OR FAILED)
            if (totalscore <= 14)
            {
                label25.Text = "FAILED!!";
            }
            else if (totalscore >= 15)
            {
                label25.Text = "PASSED!!";
            }
            //(WARNING:: MAHABANG IFELSE NA ULIT :>> )GETTING THE WRONG ANSWERS
            if (score1 == 0)
            {
                label27.Text = " X ";
            }
            else if (score1 == 1)
            {
                label27.Text = " 0 ";
            }


            if (score2 == 0)
            {
                label28.Text = " X ";
            }
            else if (score2 == 1)
            {
                label28.Text = " 0 ";
            }


            if (score3 == 0)
            {
                label29.Text = " X ";
            }
            else if (score3 == 1)
            {
                label29.Text = " 0 ";
            }


            if (score4 == 0)
            {
                label30.Text = " X ";
            }
            else if (score4 == 1)
            {
                label30.Text = " 0 ";
            }


            if (score5 == 0)
            {
                label31.Text = " X ";
            }
            else if (score5 == 1)
            {
                label31.Text = " 0 ";
            }


            if (score6 == 0)
            {
                label32.Text = " X ";
            }
            else if (score6 == 1)
            {
                label32.Text = " 0 ";
            }


            if (score7 == 0)
            {
                label33.Text = " X ";
            }
            else if (score7 == 1)
            {
                label33.Text = " 0 ";
            }


            if (score8 == 0)
            {
                label34.Text = " X ";
            }
            else if (score8 == 1)
            {
                label34.Text = " 0 ";
            }


            if (score9 == 0)
            {
                label35.Text = " X ";
            }
            else if (score9 == 1)
            {
                label35.Text = " 0 ";
            }


            if (score10 == 0)
            {
                label36.Text = " X ";
            }
            else if (score10 == 1)
            {
                label36.Text = " 0 ";
            }

            if (score11 == 0)
            {
                label46.Text = " X ";
            }
            else if (score11 == 1)
            {
                label46.Text = " 0 ";
            }

            if (score12 == 0)
            {
                label45.Text = " X ";
            }
            else if (score12 == 1)
            {
                label45.Text = " 0 ";
            }

            if (score13 == 0)
            {
                label44.Text = " X ";
            }
            else if (score13 == 1)
            {
                label44.Text = " 0 ";
            }

            if (score14 == 0)
            {
                label43.Text = " X ";
            }
            else if (score14 == 1)
            {
                label43.Text = " 0 ";
            }

            if (score15 == 0)
            {
                label42.Text = " X ";
            }
            else if (score15 == 1)
            {
                label42.Text = " 0 ";
            }


            if (score16 == 0)
            {
                label41.Text = " X ";
            }
            else if (score16 == 1)
            {
                label41.Text = " 0 ";
            }

            if (score17 == 0)
            {
                label40.Text = " X ";
            }
            else if (score17 == 1)
            {
                label40.Text = " 0 ";
            }


            if (score18 == 0)
            {
                label39.Text = " X ";
            }
            else if (score18 == 1)
            {
                label39.Text = " 0 ";
            }

            if (score18 == 0)
            {
                label38.Text = " X ";
            }
            else if (score19 == 1)
            {
                label38.Text = " 0 ";
            }


            if (score20 == 0)
            {
                label37.Text = " X ";
            }
            else if (score20 == 1)
            {
                label37.Text = " 0 ";
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}