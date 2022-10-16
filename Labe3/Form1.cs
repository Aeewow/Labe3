namespace Labe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                var firstLength = new Length(firstValue, MeasureType.m);
                var secondLength = new Length(secondValue, MeasureType.m);

               
                Length sumLength;

                
                switch (cmbOperation.Text)
                {
                    case "+":
                        
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        
                        sumLength = firstLength - secondLength;
                        break;
                    default:
                        sumLength = new Length(0, MeasureType.m);
                        break;
                }

                txtResult.Text = sumLength.Verbose();

            }
            catch (FormatException)
            {
                return;
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();            
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}