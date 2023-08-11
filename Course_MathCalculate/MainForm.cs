using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Course_MathCalculate
{
    public partial class MainForm : Form
    {
        private HistoryForm historyForm;
        [DllImport("DLL.dll")]
        static extern void ReturnResult(string s1, ref string s2);
        [DllImport("DLL.dll")]
        static extern void ReturnPostfixForm(string s1, ref string s2);
        public MainForm()
        {
            InitializeComponent();
            labelFirstColumnIndex.Text = "Expression";
            labelSecondColumnIndex.Text = "Postfix Form";
            labelThirdColumnIndex.Text = "Result";
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string mathExpr = textBoxExpression.Text;
            string postfixForm = "";
            string result = "";
            ReturnResult(mathExpr, ref result);
            ReturnPostfixForm(mathExpr, ref postfixForm);
            labelFirstColumnValue.Text = mathExpr;
            labelSecondColumnValue.Text = postfixForm;
            labelThirdColumnValue.Text = result;
            if (labelFirstColumnValue.Visible == false) labelFirstColumnValue.Visible = true;
            if (labelSecondColumnValue.Visible == false) labelSecondColumnValue.Visible = true;
            if (labelThirdColumnValue.Visible == false) labelThirdColumnValue.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = textBoxExpression.Text.Remove(0);
            labelFirstColumnValue.Text = labelFirstColumnValue.Text.Remove(0);
            labelSecondColumnValue.Text = labelSecondColumnValue.Text.Remove(0);
            labelThirdColumnValue.Text = labelThirdColumnValue.Text.Remove(0);
            labelFirstColumnValue.Visible = false;
            labelSecondColumnValue.Visible = false;
            labelThirdColumnValue.Visible = false;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (historyForm == null) historyForm = new HistoryForm(this);
            this.Hide();
            historyForm.Show();
        }
    }
}
