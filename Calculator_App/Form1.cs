namespace Calculator_App
{
    public partial class Form1 : Form
    {
        double _operand1;
        double _operand2;
        char _operator;
        public Form1()
        {
            InitializeComponent();
            // constructor initializes the form , sets default values for operand 1 and 2 
            _operand1 = 0;
            _operand2 = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            /*
            This method handles number button clicks from 0 -> 9
            If the user needs to enter a multi-digit number : 15
            concatenating each button click appends to the result display
           */
            Button btn = sender as Button;
            result.Text += btn.Text;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            // this is use for decimal number ,  ensuring no duplicate "." is added
            if (!result.Text.Contains(".") && !string.IsNullOrEmpty(result.Text))
            {
                result.Text += ".";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // clear result label , resets operands values 
            result.Text = "";
            _operand1 = 0;
            _operand2 = 0;
        }

        private void btn_operator(object sender, EventArgs e)
        {
            // first : store operand1 value 
            // then store operator ( + - * / ) 
            _operand1 = Convert.ToDouble(result.Text);
            Button btn = sender as Button;
            _operator = Convert.ToChar(btn.Text);
            result.Text = "";
        }

        private void button_equal(object sender, EventArgs e)
        {
            /*
             * store operand2 value
             * performs the operation , depends on specific operator value
             * displays the result in result label
             */
            try
            {

                _operand2 = Convert.ToDouble(result.Text);
                double res;
                switch (_operator)
                {
                    case '+': res = _operand1 + _operand2; break;
                    case '-': res = _operand1 - _operand2; break;
                    case '*': res = _operand1 * _operand2; break;
                    case '/': res = _operand1 / _operand2; break;
                    case 'p': res = Math.Pow(_operand1, _operand2); break;
                    default: res = 0; break;
                }
                pow.Checked = false;
                result.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _operand1 = 0;
                _operand2 = 0;
                result.Text = "";
            }
        }

        private void rbtn_simple_CheckedChanged(object sender, EventArgs e)
        {
            // switches to simple mode by hiding the scientific group box 
            grpBox_scientific.Visible = false;
        }

        private void rbtn_scentific_CheckedChanged(object sender, EventArgs e)
        {
            // scientific mode by displaying the scientific group box
            grpBox_scientific.Visible = true;
        }

        private void scientific_operatt(object sender, EventArgs e)
        {
            // performs scientific operation ( cos, sin, sqrt) on operand1 
            try
            {
                _operand1 = Convert.ToDouble(result.Text);
                RadioButton rbt = sender as RadioButton;
                double res;
                switch (rbt.Text)
                {
                    case "cos": res = Math.Round(Math.Cos(_operand1), 4); break;
                    case "sin": res = Math.Round(Math.Sin(_operand1), 4); break;
                    case "sqrt": res = Math.Sqrt(_operand1); break;
                    default: res = 0; break;
                }
                result.Text = res.ToString();
                rbt.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void power_radio(object sender, EventArgs e)
        {
            /*
             * specific method for the pow operation 
             * since pow need 2 operand  
             */
            _operand1 = Convert.ToDouble(result.Text);
            _operand2 = 'p';
            result.Text = "";
        }

        private void ToggleBackgroundColor(object sender, EventArgs e)
        {
            // change background color 
            if (backColor.Checked)
            {
                BackColor = Color.LightSteelBlue;
            }
            else if (!backColor.Checked)
            {
                BackColor = Color.LightGray;
            }

        }
        private void ToggleFont(object sender, EventArgs e)
        {
            // change font color, style, type...
            if (fontColor.Checked)
            {
                Font = new Font("sans serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                this.ForeColor = Color.Blue;
            }
            else if (!fontColor.Checked)
            {
                Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                this.ForeColor = Color.Black;
            }
        }
    }
}