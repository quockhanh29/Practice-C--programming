using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace chapter12_1_1
{
    public class TestForm : Form
    {
        public TestForm()
        {
            string formTitle = "Windows10 GUI";
            int formWidth = 400;
            int formHeight = 300;

            this.Text = formTitle;
            this.Width = formWidth;
            this.Height = formHeight;
        }
    }

    class chapter12_1_1
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            TestForm testform = new TestForm();
            Application.Run(testform);
        }
    }
}