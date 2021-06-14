using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace chapter12_1_1
{
    class ControlFrom : Form
    {
        public ControlFrom()
        {

            // button
            Button button = new Button();
            button.Text = "ボタン";
            button.Top = 0;
            button.Left = 0;
            this.Controls.Add(button);

            // checkbox 1
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Text = "チャックボックス1";
            checkBox1.Checked = true;
            checkBox1.Top = 30;
            checkBox1.Left = 0;
            this.Controls.Add(checkBox1);

            // checkBox 2
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Text = "チャックボックス2";
            checkBox2.Checked = false;
            checkBox2.Top = 30;
            checkBox2.Left = 120;
            this.Controls.Add(checkBox2);

            // raidobutton 1
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Text = "ラジオボタン1";
            radioButton1.Checked = true;
            radioButton1.Top = 60;
            radioButton1.Left = 0;
            this.Controls.Add(radioButton1);

            // radiobutton 2
            RadioButton radioButton2 = new RadioButton();
            radioButton2.Text = "ラジオボタン2";
            radioButton2.Checked = false;
            radioButton2.Top = 60;
            radioButton2.Left = 120;
            this.Controls.Add(radioButton2);

            // textbox
            TextBox textBox = new TextBox();
            textBox.Text = "テキストボックス";
            textBox.Top = 90;
            textBox.Left = 0;
            this.Controls.Add(textBox);

            // label
            Label label = new Label();
            label.Text = "ラベル";
            label.Top = 120;
            label.Left = 0;
            this.Controls.Add(label);

        }
    }
    class chapter12_2_1
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new ControlFrom());
        }
    }
}