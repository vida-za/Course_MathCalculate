using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Course_MathCalculate
{
    public partial class MainForm : Form
    {
        [DllImport("DLL.dll")]
        static extern void ReturnResult(string s1, ref string s2);
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string mathExpr = textBoxExpression.Text;
            string result = "";
            ReturnResult(mathExpr, ref result);
            labelPrint.Text = result;
            if (labelPrint.Visible == false) labelPrint.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelPrint.Text = labelPrint.Text.Remove(0);
            labelPrint.Visible = false;
        }
    }
}
