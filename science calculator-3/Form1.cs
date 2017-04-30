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

        private void standardToolStripMenuItem_Click(object sender, EventArgs e) //第一步
        {
            this.Width = 220;
            result.Width = 170;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 420;
            result.Width = 370;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 220;
            result.Width = 170;
        }

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

        private void button_п_Click(object sender, EventArgs e) //第九步
        {
            result.Text = "3.1415926";
        }

        private void button_Log_Click(object sender, EventArgs e) //第十步
        {
            double ilog = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            ilog = Math.Log10(ilog);
            result.Text = System.Convert.ToString(ilog);
        }

        private void button_Sqrt_Click(object sender, EventArgs e) 
        {
            double sq = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sqrt" + "(" + (result.Text) + ")");
            sq  = Math.Sqrt(sq);
            result.Text = System.Convert.ToString(sq);
        }

        private void button_Sinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sinh" + "(" + (result.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            result.Text = System.Convert.ToString(qSinh);
        }

        private void button_Sin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Sin" + "(" + (result.Text) + ")");
            qSin = Math.Sin(qSin);
            result.Text = System.Convert.ToString(qSin);
        }

        private void button_Cosh_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Cosh" + "(" + (result.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            result.Text = System.Convert.ToString(qCosh);
        }

        private void button_Cos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Cos" + "(" + (result.Text) + ")");
            qCos = Math.Cos(qCos);
            result.Text = System.Convert.ToString(qCos);
        }

        private void button_Tanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Tanh" + "(" + (result.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            result.Text = System.Convert.ToString(qTanh);
        }

        private void button_Tan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("Tan" + "(" + (result.Text) + ")");
            qTan = Math.Tan(qTan);
            result.Text = System.Convert.ToString(qTan);
        }

        private void button_Bin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        private void button_Hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        private void button_Oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        private void button_Dec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble (result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button_cube_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button_1_Click(object sender, EventArgs e) //為1/x
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(result.Text));
            result.Text = System.Convert.ToString(a);
        }

        private void button_2_Click(object sender, EventArgs e) //為ln x
        {
            double ilog = Double.Parse(result.Text);
            equation.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            ilog = Math.Log(ilog);
            result.Text = System.Convert.ToString(ilog);
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(a);
        }

        private void button_plus_minus_Click(object sender, EventArgs e) //加入正副號的程式
        {
            if (double .Parse (result.Text)!=0) // 0 是無關正負的，毋須處理。
            {
                if (result.Text.IndexOf("-")>=0)
                {
                    result.Text = result.Text.Replace("-", ""); //Replace("-","")的意思是將字串result.Text中的"-"變成""(空字串)，也就是刪除負號變成正數了
                }
                else
                {
                    result.Text = "-" + result.Text; //原字串中如果沒有負號("-")，表示是正數，就應該給它加上負號變成負數了
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)  //日期計算
        {

        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            DateTime sdt = dateTimePicker1.Value.Date;
            DateTime edt = dateTimePicker2.Value.Date;

            TimeSpan ts = edt - sdt;

            int days = ts . Days;

            difference_two_dates_value.Text = days.ToString() + "Days";
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e) //Date面板寬度
        {
            this.Width = 680;
            result.Width = 370;
        }

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

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)  //單位轉換面板寬度
        {
            this.Width = 950;
            result.Width = 370;
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            historyToolStripMenuItem.Visible = true;
            listBox1.Width = 420;
            listBox1.Visible = false;
            this.Height = 320;
            historyToolStripMenuItem1.Visible = false;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyToolStripMenuItem.Checked == true)
            {
                listBox1.Visible = true;
                historyToolStripMenuItem.Visible = false;
                historyToolStripMenuItem.Visible = true;
                this.Height = 320;
            }
        }
    }
}
        
    
