using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
namespace WindowsFormsApplication1
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
    class ControlForm : Form
    {
        private int i = 0;
        RoundButton  button;
        public ControlForm()
        {

            button = new RoundButton();
            button.Text = "ボタン";
            button.Top = 50;
            button.Left = 50;
            button.Width = 70;
            button.Height = 70;
            button.Click += button_Click;
            //button.BackColor = Color.Red;
            this.Controls.Add(button);
        }
        public void button_Click(Object sender, EventArgs e)
        {
            //label.Text = "ボタンがクリックされました";
            i = i%2;
            if(i == 0)
            {
                button.BackColor = Color.Red;
            }
            else
            {
                button.BackColor = Color.Blue;
            }
            i++;
        }
    }

    class program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new ControlForm());
        }
    }
}