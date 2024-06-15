using static CalculatorApplication.CalculatorClass;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;

        public Form1()
        {
            InitializeComponent();

            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtBoxInput1.Text);
            num2 = Double.Parse(txtBoxInput2.Text);

            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblAnswer.Text = (cal.GetSum(num1, num2)).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }//end tag

            else if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblAnswer.Text = (cal.GetDifference(num1, num2)).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }

            else if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblAnswer.Text = (cal.GetProduct(num1, num2)).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }

            else if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblAnswer.Text = (cal.GetQuotient(num1, num2)).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }


            //end
        }
    }
}