using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace science_calculator_3
{
    public partial class Form1 : Form
    {
        Double value = 0;  //第二步
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 220;
            result.Width = 170;
        }



        #region Function



        #region Stnadard

        private void Button_Click(object sender, EventArgs e) //第三步
        {
            if ((result.Text == "0") || (operation_pressed)) //開始按數字時，0會消失
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender; //b可能是0~9
            result.Text = result.Text + b.Text;//呼叫b的text
        }

        private void button_CE_Click(object sender, EventArgs e) //第四步
        {
            result.Text = "0";
        }

        private void button_C_Click(object sender, EventArgs e) //第五步
        {
            result.Text = "0";
            value = 0;
        }

        private void button_Clear_Click(object sender, EventArgs e) //第六步
        {
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
            if (result.Text == "")
            {
                result.Text = "0";
            }
        }

        private void operator_click(object sender, EventArgs e) //第七步
        {
            Button b = (Button)sender;    //創建一個button b,b只可能是+-x/
            operation = b.Text;          //如果是按+這個運算子,就會把+這個字串給 operation
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + "" + operation;
        }

        private void button_equal_Click(object sender, EventArgs e) //第八步
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break; //跳出迴圈
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break;
                case "Mod":
                    result.Text = (value % Double.Parse(result.Text)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break;
                case "Exp":
                    double i = Double.Parse(result.Text);
                    double q;
                    q = (value);
                    result.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    listBox1.Items.Add((value + Double.Parse(result.Text)).ToString(result.Text));
                    break;
                default:
                    break;
            }
        }

        private void button_plus_minus_Click(object sender, EventArgs e) //加入正副號的程式
        {
            if (double.Parse(result.Text) != 0) // 0 是無關正負的，毋須處理。
            {
                if (result.Text.IndexOf("-") >= 0)
                {
                    result.Text = result.Text.Replace("-", ""); //Replace("-","")的意思是將字串result.Text中的"-"變成""(空字串)，也就是刪除負號變成正數了
                }
                else
                {
                    result.Text = "-" + result.Text; //原字串中如果沒有負號("-")，表示是正數，就應該給它加上負號變成負數了
                }
            }
        }

        #endregion

        #region Scientific

        int a;
        Double A;

        // Pi
        private void button_п_Click(object sender, EventArgs e) //第九步
        {
            result.Text = "3.1415926";
        }

        // Log
        private void button_Log_Click(object sender, EventArgs e) //第十步
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            A = Math.Log10(A);
            result.Text = System.Convert.ToString(A);
        }

        // Sqrt
        private void button_Sqrt_Click(object sender, EventArgs e) 
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sqrt" + "(" + (result.Text) + ")");
            A  = Math.Sqrt(A);
            result.Text = System.Convert.ToString(A);
        }

        // Sinh
        private void button_Sinh_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sinh" + "(" + (result.Text) + ")");
            A = Math.Sinh(A);
            result.Text = System.Convert.ToString(A);
        }

        // Sin
        private void button_Sin_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sin" + "(" + (result.Text) + ")");
            A = Math.Sin(A);
            result.Text = System.Convert.ToString(A);
        }

        // Cosh
        private void button_Cosh_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Cosh" + "(" + (result.Text) + ")");
            A = Math.Cosh(A);
            result.Text = System.Convert.ToString(A);
        }

        // Cos
        private void button_Cos_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Cos" + "(" + (result.Text) + ")");
            A = Math.Cos(A);
            result.Text = System.Convert.ToString(A);
        }

        // Tanh
        private void button_Tanh_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Tanh" + "(" + (result.Text) + ")");
            A = Math.Tanh(A);
            result.Text = System.Convert.ToString(A);
        }

        // Tan
        private void button_Tan_Click(object sender, EventArgs e)
        {
            A = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Tan" + "(" + (result.Text) + ")");
            A = Math.Tan(A);
            result.Text = System.Convert.ToString(A);
        }

        // Binary
        private void button_Bin_Click(object sender, EventArgs e)
        {
            a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        // Hex
        private void button_Hex_Click(object sender, EventArgs e)
        {
            a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        // Oct
        private void button_Oct_Click(object sender, EventArgs e)
        {
            a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        // Dec
        private void button_Dec_Click(object sender, EventArgs e)
        {
            a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a);
        }
        
        // square
        private void button_square_Click(object sender, EventArgs e)
        {
            
            A = Convert.ToDouble (result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        // cube
        private void button_cube_Click(object sender, EventArgs e)
        {
           
            A = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(A);
        }

        // 1/x
        private void button_1_Click(object sender, EventArgs e) //為1/x
        {
            A = Convert.ToDouble(1.0 / Convert.ToDouble(result.Text));
            result.Text = System.Convert.ToString(A);
        }

        // Log
        private void button_2_Click(object sender, EventArgs e) //為ln x
        {
            equation.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            A = Double.Parse(result.Text);  
            A = Math.Log(A);
            result.Text = System.Convert.ToString(A);
        }

        // percent
        private void button_percent_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(A);
        }

        #endregion

        #region Date

        private void btn_cal_Click(object sender, EventArgs e)
        {
            DateTime sdt = dateTimePicker1.Value.Date;
            DateTime edt = dateTimePicker2.Value.Date;

            TimeSpan ts = edt - sdt;

            difference_two_dates_value.Text = ((int)ts.Days).ToString() + "Days";
        }

        #endregion

        #region Unit Conversion

        private void button_convert_to_KGs_Click(object sender, EventArgs e)  //單位轉換
        {
            double Pound = (double)numericUpDown2.Value;
            double Answer = Pound * 0.453592;
            answer.Text = Answer.ToString() + "KGs";
        }

        private void button_convert_to_pounds_Click(object sender, EventArgs e)
        {
            double KGs = (double)numericUpDown1.Value;
            double Answer = KGs * 2.20462;
            answer.Text = Answer.ToString() + "Pound";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
            numericUpDown1.Value = 0;
            answer.Text = "Answer:";   //接著更改numericUpDown1&2的屬性maximum值:5000
        }

        #endregion



        #endregion


        #region ToolStripMenu

        int [] x = new int[]{220,420,680,950};
        int[] r_x = new int[] { 170,370};
        int[] y = new int []{347,414};

        // standard ToolStripMenu
        private void standardToolStripMenuItem_Click(object sender, EventArgs e) //第一步
        {
            this.Width = x[0];
            result.Width = r_x[0];

            Scientific_groupBox.Visible = false;

            Date_groupBox.Visible = false;
            Unit_Conversion_groupBox.Visible = false;

            dateToolStripMenuItem.Checked = false;
            unitConversionToolStripMenuItem.Checked = false;
        }

        // Scientific ToolStripMenu
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = x[1];
            result.Width = r_x[1];

            Scientific_groupBox.Visible = true;

            Date_groupBox.Visible = false;
            Unit_Conversion_groupBox.Visible = false;

            dateToolStripMenuItem.Checked = false;
            unitConversionToolStripMenuItem.Checked = false;
        }

        // Date ToolStripMenu
        private void dateToolStripMenuItem_Click(object sender, EventArgs e) //Date面板寬度
        {
            Scientific_groupBox.Visible = true;
            this.Width = x[1];
            result.Width = r_x[1];
            listBox1.Width = result.Width;

            // 改變 checked
            switch (Date_groupBox.Visible)
            {
                case true:  
                    Date_groupBox.Visible = false;
                    dateToolStripMenuItem.Checked = false;
                    break;
                case false:
                    Date_groupBox.Visible = true;
                    dateToolStripMenuItem.Checked = true;
                    break;
            }

            // 判斷顯示
            if (dateToolStripMenuItem.Checked && unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[3];
                Unit_Conversion_groupBox.Location = new Point(675, 27);
            }
            else if (dateToolStripMenuItem.Checked || unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[2];
                if (unitConversionToolStripMenuItem.Checked)
                {
                    Unit_Conversion_groupBox.Location = Date_groupBox.Location;
                }   
            }
            else if (!dateToolStripMenuItem.Checked && !unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[1];
            }
        }

        // Unit Conversion ToolStripMenu
        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)  //單位轉換面板寬度
        {
            Scientific_groupBox.Visible = true;
            this.Width = x[1];
            result.Width = r_x[1];
            listBox1.Width = result.Width;

            // 改變 checked
            switch (Unit_Conversion_groupBox.Visible)
            {
                case true:
                    Unit_Conversion_groupBox.Visible = false;
                    unitConversionToolStripMenuItem.Checked = false;
                    break;
                case false:
                    Unit_Conversion_groupBox.Visible = true;
                    unitConversionToolStripMenuItem.Checked = true;
                    break;
            }

             // 判斷顯示
            if (dateToolStripMenuItem.Checked && unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[3];
                Unit_Conversion_groupBox.Location = new Point(675, 27);
            }
            else if (dateToolStripMenuItem.Checked || unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[2];
                if (unitConversionToolStripMenuItem.Checked)
                {
                    Unit_Conversion_groupBox.Location = Date_groupBox.Location;
                }   
            }
            else if (!dateToolStripMenuItem.Checked && !unitConversionToolStripMenuItem.Checked)
            {
                this.Width = x[1];
            }
        

            
        }

        // History ToolStripMenu
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 無到有
            if (historyToolStripMenuItem.Checked == true)
            {
                listBox1.Width = result.Width;
                listBox1.Visible = true;
                historyToolStripMenuItem.Checked = true;
                this.Height = y[0];
            }
            // 有到無
            else
            {
                historyToolStripMenuItem.Checked = false;
                
                listBox1.Visible = false;
                this.Height = y[1];
            }

        }

        #endregion

    }
}
        
    
