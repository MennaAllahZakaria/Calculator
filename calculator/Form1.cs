namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfloat_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '.';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '9';
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            input.Clear();
            answer.Clear();
        }
        float num;
        int count;
        private void btnminus_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            {
                num = float.Parse(input.Text);
                answer.Text = input.Text + '-';
                input.Clear();
                count = 1;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {

            if (input.Text != "")
            {
                num = float.Parse(input.Text);
                answer.Text = input.Text + '+';
                input.Clear();
                count = 2;
            }
        }

        private void btnmltu_Click(object sender, EventArgs e)
        {

            if (input.Text != "")
            {
                num = float.Parse(input.Text);
                answer.Text = input.Text + '*';
                input.Clear();
                count = 3;
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {

            if (input.Text != "")
            {
                num = float.Parse(input.Text);
                answer.Text = input.Text + '/';
                input.Clear();
                count = 4;
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {

            if (input.Text != "")
            {
                num = float.Parse(input.Text);
                answer.Text = input.Text + '%';
                input.Clear();
                count = 5;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(input.Text);
                    answer.Text += input.Text + " = " + ans;
                    input.Text = ans.ToString(); break;
                case 2:
                    ans = num + float.Parse(input.Text);
                    answer.Text += input.Text + " = " + ans;
                    input.Text = ans.ToString(); break;
                case 3:
                    ans = num * float.Parse(input.Text);
                    answer.Text += input.Text + " = " + ans;
                    input.Text = ans.ToString(); break;
                case 4:
                    ans = num / float.Parse(input.Text);
                    answer.Text += input.Text + " = " + ans;
                    input.Text = ans.ToString(); break;
                case 5:
                    ans = num % float.Parse(input.Text);
                    answer.Text += input.Text + " = " + ans;
                    input.Text = ans.ToString();

                    break;

            }
        }
    }
}