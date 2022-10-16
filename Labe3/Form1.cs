namespace Labe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[]
            {
                "μ/c.",
                "κμ/χ.",
                "ση.",
                 "Μ",
            };

            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
        }
        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch(comboBox.Text)
            {
                case "μ/c.":
                    measureType = MeasureType.m;
                    break;
                case "κμ/χ.":
                    measureType = MeasureType.km;
                    break;
                case "ση.":
                    measureType = MeasureType.kn;
                    break;
                case "Μ":
                    measureType= MeasureType.M;
                    break;
                default:
                    measureType = MeasureType.m;
                    break;
            }
            return measureType;
        }
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);

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
                    case "*":
                        sumLength = firstLength * secondLength;
                        break;
                    /*case "=":
                        sumLength = Compare()
                    default:*/
                        sumLength = new Length(0, MeasureType.m);
                        break;
                }
                txtResult.Text = sumLength.ConvertTo(resultType).Verbose();
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}