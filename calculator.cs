using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace calculator
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(-1, -1, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
    class calculator : Form
    {
        TextBox display;

        RoundButton button1;
        RoundButton button2;
        RoundButton button3;
        RoundButton button4;
        RoundButton button5;
        RoundButton button6;
        RoundButton button7;
        RoundButton button8;
        RoundButton button9;
        RoundButton button0;
        RoundButton buttonPlus;
        RoundButton buttonMinus;
        RoundButton buttonMulti;
        RoundButton buttonDivision;
        RoundButton buttonTotal;
        RoundButton buttonClear;
        RoundButton buttonOnOff;

        bool arithmeticFlg;
        bool OnOffFlg;
        int bufferNumber;
        string bufferOperator;

        [DllImport ( "User32.dll" )]
        static extern Boolean HideCaret ( System.IntPtr hWnd );
        
        public calculator()
        {
            int formWidth = 400;
            int formHeight = 650;
            string formTitle = "電卓アプリ";

            this.Width = formWidth;
            this.Height = formHeight;
            this.Text = formTitle;

            // textbox
            display = new TextBox();
            display.Width = 350;
            display.Height = 100;
            display.Location = new Point(20, 0);
            display.Text = "";
            display.Font = new Font("Arial", 55);
            display.TextAlign = HorizontalAlignment.Right;
            display.BackColor = Color.White;
            display.ReadOnly = true;
            display.GotFocus += display_gotfocus;
            this.Controls.Add(display);           

            //button
            button1 = new RoundButton();
            button1.Text= "1";
            button1.Font = new Font("Arial", 30);
            button1.Width = 80;
            button1.Height = 80;
            button1.Location = new Point(20, 120);
            button1.BackColor = Color.Blue;
            button1.Click += Number_click;
            this.Controls.Add(button1);

            button2 = new RoundButton();
            button2.Text = "2";
            button2.Font = new Font("Arial", 30);
            button2.Width = 80;
            button2.Height = 80;
            button2.Location = new Point(110, 120);
            button2.BackColor = Color.Blue;
            button2.Click += Number_click;
            this.Controls.Add(button2);

            button3 = new RoundButton();
            button3.Text = "3";
            button3.Font = new Font("Arial", 30);
            button3.Width = 80;
            button3.Height = 80;
            button3.Location = new Point(200, 120);
            button3.BackColor = Color.Blue;
            button3.Click += Number_click;
            this.Controls.Add(button3);

            button4 = new RoundButton();
            button4.Text = "4";
            button4.Font = new Font("Arial", 30);
            button4.Width = 80;
            button4.Height = 80;
            button4.Location = new Point(20, 210);
            button4.BackColor = Color.Blue;
            button4.Click += Number_click;
            this.Controls.Add(button4);

            button5 = new RoundButton();
            button5.Text = "5";
            button5.Font = new Font("Arial", 30);
            button5.Width = 80;
            button5.Height = 80;
            button5.Location = new Point(110, 210);
            button5.BackColor = Color.Blue;
            button5.Click += Number_click;
            this.Controls.Add(button5);

            button6 = new RoundButton();
            button6.Text = "6";
            button6.Font = new Font("Arial", 30);
            button6.Width = 80;
            button6.Height = 80;
            button6.Location = new Point(200, 210);
            button6.BackColor = Color.Blue;
            button6.Click += Number_click;
            this.Controls.Add(button6);

            button7 = new RoundButton();
            button7.Text = "7";
            button7.Font = new Font("Arial", 30);
            button7.Width = 80;
            button7.Height = 80;
            button7.Location = new Point(20, 300);
            button7.BackColor = Color.Blue;
            button7.Click += Number_click;
            this.Controls.Add(button7);

            button8 = new RoundButton();
            button8.Text = "8";
            button8.Font = new Font("Arial", 30);
            button8.Width = 80;
            button8.Height = 80;
            button8.Location = new Point(110, 300);
            button8.BackColor = Color.Blue;
            button8.Click += Number_click;
            this.Controls.Add(button8);

            button9 = new RoundButton();
            button9.Text = "9";
            button9.Font = new Font("Arial", 30);
            button9.Width = 80;
            button9.Height = 80;
            button9.Location = new Point(200, 300);
            button9.BackColor = Color.Blue;
            button9.Click += Number_click;
            this.Controls.Add(button9);

            button0 = new RoundButton();
            button0.Text = "0";
            button0.Font = new Font("Arial", 30);
            button0.Width = 80;
            button0.Height = 80;
            button0.Location = new Point(20, 390);
            button0.BackColor = Color.Blue;
            button0.Click += Number_click;
            this.Controls.Add(button0);            

            buttonPlus = new RoundButton();
            buttonPlus.Text = "+";
            buttonPlus.Font = new Font("Arial", 30);
            buttonPlus.Width = 80;
            buttonPlus.Height = 80;
            buttonPlus.Location = new Point(290, 120);
            buttonPlus.BackColor = Color.Silver;
            buttonPlus.Click += Arithmetic_click;
            this.Controls.Add(buttonPlus);

            buttonMinus = new RoundButton();
            buttonMinus.Text = "-";
            buttonMinus.Font = new Font("Arial", 30);
            buttonMinus.Width = 80;
            buttonMinus.Height = 80;
            buttonMinus.Location = new Point(290, 210);
            buttonMinus.BackColor = Color.Silver;
            buttonMinus.Click += Arithmetic_click;
            this.Controls.Add(buttonMinus);

            buttonMulti = new RoundButton();
            buttonMulti.Text = "x";
            buttonMulti.Font = new Font("Arial", 30);
            buttonMulti.Width = 80;
            buttonMulti.Height = 80;
            buttonMulti.Location = new Point(290, 300);
            buttonMulti.BackColor = Color.Silver;
            buttonMulti.Click += Arithmetic_click;
            this.Controls.Add(buttonMulti);

            buttonDivision = new RoundButton();
            buttonDivision.Text = "÷";
            buttonDivision.Font = new Font("Arial", 30);
            buttonDivision.Width = 80;
            buttonDivision.Height = 80;
            buttonDivision.Location = new Point(290, 390);
            buttonDivision.BackColor = Color.Silver;
            buttonDivision.Click += Arithmetic_click;
            this.Controls.Add(buttonDivision);

            buttonTotal = new RoundButton();
            buttonTotal.Text = "=";
            buttonTotal.Font = new Font("Arial", 30);
            buttonTotal.Width = 170;
            buttonTotal.Height = 80;
            buttonTotal.Location = new Point(110, 390);
            buttonTotal.BackColor = Color.Red;
            buttonTotal.Click += Total_click;
            this.Controls.Add(buttonTotal);   

            buttonClear = new RoundButton();
            buttonClear.Text = "C";
            buttonClear.Font = new Font("Arial", 30);
            buttonClear.Width = 80;
            buttonClear.Height = 80;
            buttonClear.Location = new Point(20, 480);
            buttonClear.BackColor = Color.Gray;
            buttonClear.Click += Clear_click;
            this.Controls.Add(buttonClear);   

            buttonOnOff = new RoundButton();
            buttonOnOff.Text = "On/Off";
            buttonOnOff.Font = new Font("Arial", 30);
            buttonOnOff.Width = 170;
            buttonOnOff.Height = 80;
            buttonOnOff.Location = new Point(110, 480);
            buttonOnOff.BackColor = Color.Gray;
            buttonOnOff.Click += OnOff_click;
            this.Controls.Add(buttonOnOff);

        }
        void Number_click(object sender, EventArgs e)
        {
            if(OnOffFlg == true){
            if(display.Text.Length >= 8)
            {
                return;
            }
            string clickNumber = ((RoundButton)sender).Text;

            if(display.Text == "0")
            {
                display.Text = clickNumber;
            }
            else
            {
                display.Text = display.Text +clickNumber;
            }
            }
            else{
                return;
            }
        }
        void Arithmetic_click(object sender, EventArgs e)
        {
            if(OnOffFlg == true){
            if(arithmeticFlg == true)
            {
                return;
            }
            bufferOperator = ((RoundButton)sender).Text;
            bufferNumber = int.Parse(display.Text);
            display.Text = "0";
            arithmeticFlg = true;
            }
            else{
                return;
            }
        }
        void Total_click(object sender, EventArgs e)
        {
            if(OnOffFlg == true){
            try
            {
                if(arithmeticFlg == false)
                {
                    return;
                }
                if(bufferOperator == "+")
                {
                    display.Text = (bufferNumber + int.Parse(display.Text)).ToString();
                }
                else if(bufferOperator == "-")
                {
                    display.Text = (bufferNumber - int.Parse(display.Text)).ToString();
                }
                else if(bufferOperator == "x")
                {
                    display.Text = (bufferNumber * int.Parse(display.Text)).ToString();
                }
                else if(bufferOperator == "÷")
                {
                    try
                    {
                        display.Text = (bufferNumber / int.Parse(display.Text)).ToString();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("indivisible by 0");
                        display.Text ="0";
                        return;
                    }
                }
            }
            catch(Exception)
            {
                display.Text = "ERROR404";
            }
            finally
            {
                arithmeticFlg = false;
            }
            }
            else{
                return;
            }
        }

        void Clear_click(object sender, EventArgs e)
        {
            if(OnOffFlg == true)
            {
                arithmeticFlg = false;
                bufferNumber = 0;
                bufferOperator = "";
                display.Text = "0";
            }
            else
            {
                return;
            }
        }
        void OnOff_click(object sender, EventArgs e)
        {
            OnOffFlg = OnOffFlg? false : true;
            if(OnOffFlg == true)
            {
                display.Text = "0";
            }
            else
            {
                display.Text ="";
            }
        }
        void display_gotfocus(object sender, EventArgs e)
        {
            HideCaret(display.Handle);
        }

    }
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new calculator());
        }
    }
}