using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_MathCalculate
{
    public partial class MainForm : Form
    {
        [DllImport("DLL.dll", CharSet = CharSet.Ansi)]
        public static extern void TestFunc(IntPtr Expression, ref int size);
        [DllImport("DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void TestFunc2(IntPtr str1, string str2, IntPtr size);
        [DllImport("DLL.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr TestFunc3(string str1, string str2);
        [DllImport("DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void deleteString(IntPtr str);
        [DllImport("DLL.dll", CharSet = CharSet.Ansi)]
        public extern static void SaveExpression(ref string s);
        [DllImport("DLL.dll", CharSet = CharSet.Ansi)]
        public extern static void Calculate();
        [DllImport("DLL.dll", CharSet = CharSet.Ansi)]
        public extern static void ShowSolution(ref string s);
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = false;
            string s = textBoxExpression.Text;
            SaveExpression(ref s);
            Calculate();
            ShowSolution(ref s);
            labelPrint.Text = s;
            if (labelPrint.Visible == false) labelPrint.Visible = true;

            /*Some Error variant*/
            //var pStr1 = Marshal.AllocHGlobal(4096);
            //var data = Encoding.Unicode.GetBytes(textBoxExpression.Text);
            //Marshal.Copy(data, 0, pStr1, data.Length);
            //TestFunc2(pStr1, "Hello", new IntPtr(4096));
            //var result = Marshal.PtrToStringUni(pStr1);
            //Marshal.FreeHGlobal(pStr1);
            //labelPrint.Text = result;
            //if (labelPrint.Visible == false) labelPrint.Visible = true;


            /*Error variant*/
            //var Expr = Marshal.AllocHGlobal(256);
            //int size = 256;
            //TestFunc(Expr, ref size);
            //labelPrint.Text = Marshal.PtrToStringUni(Expr);
            //Marshal.FreeHGlobal(Expr);

            //IntPtr pRes = TestFunc3(textBoxExpression.Text, "Hello");
            //var result = Marshal.PtrToStringUni(pRes);
            //deleteString(pRes);
            //labelPrint.Text = result;
            //if (labelPrint.Visible == false) labelPrint.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = true;
            labelPrint.Text = labelPrint.Text.Remove(0);
            labelPrint.Visible = false;
        }
    }
}
