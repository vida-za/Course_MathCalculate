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
    public partial class HistoryForm : Form
    {
        [DllImport("DLL.dll")]
        extern static void SizeHistory(ref int count);
        [DllImport("DLL.dll")]
        extern static void ReadMyFileSolution(ref string s1, ref string s2, ref string s3, ref int ID);
        [DllImport("DLL.dll")]
        extern static IntPtr CalcEqual(string s, ref int length);
        [DllImport("DLL.dll")]
        extern static void ClearEqual(IntPtr ptr);

        MainForm mainForm;
        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(MainForm prevForm)
        {
            InitializeComponent();
            ResetData();
            mainForm = prevForm;
        }

        private void buttonBack_Click(object sender, EventArgs e) 
        {
            this.Hide();
            mainForm.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0) textBoxSearch.Text = textBoxSearch.Text.Remove(0);
            ResetData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int length = 0;
            string findExpr = textBoxSearch.Text;
            IntPtr ptr = CalcEqual(findExpr, ref length);
            if (ptr.ToString() != "0")
            {
                //IntPtr start = IntPtr.Add(ptr, 4);
                try
                {
                    int[] result = new int[length];
                    Marshal.Copy(ptr, result, 0, length);
                    ClearEqual(ptr);
                    ResetData(result);
                }
                catch (Exception ex)
                {
                    textBoxSearch.Text = ex.Message;
                }
            }
            else ResetData();
        }

        private void ResetData() 
        {
            string labelFirst, labelSecond, labelThird;
            int Count = 0;
            SizeHistory(ref Count);
            int ID;
            tableLayoutPanelValues.Controls.Clear();
            tableLayoutPanelValues.RowStyles.Clear();
            tableLayoutPanelValues.RowCount = 0;
            RowStyle temp = tableLayoutPanelIndexes.RowStyles[tableLayoutPanelIndexes.RowStyles.Count - 1];
            for (int i = 0; i < Count; i++) 
            {
                ID = i + 1;
                tableLayoutPanelValues.RowCount++;
                tableLayoutPanelValues.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 0, i);

                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 1, i);

                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 2, i);

                labelFirst = tableLayoutPanelValues.GetControlFromPosition(0, i).Text;
                labelSecond = tableLayoutPanelValues.GetControlFromPosition(1, i).Text;
                labelThird = tableLayoutPanelValues.GetControlFromPosition(2, i).Text;
                ReadMyFileSolution(ref labelFirst, ref labelSecond, ref labelThird, ref ID);
                tableLayoutPanelValues.GetControlFromPosition(0, i).Text = labelFirst;
                tableLayoutPanelValues.GetControlFromPosition(1, i).Text = labelSecond;
                tableLayoutPanelValues.GetControlFromPosition(2, i).Text = labelThird;
            }
        }

        private void ResetData(int[] IDs)
        {
            string labelFirst, labelSecond, labelThird;
            int ID;
            tableLayoutPanelValues.Controls.Clear();
            tableLayoutPanelValues.RowStyles.Clear();
            tableLayoutPanelValues.RowCount = 0;
            RowStyle temp = tableLayoutPanelIndexes.RowStyles[tableLayoutPanelIndexes.RowStyles.Count - 1];
            for (int i = 0; i < IDs.Length; i++)
            {
                ID = IDs[i];
                tableLayoutPanelValues.RowCount++;
                tableLayoutPanelValues.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 0, i);

                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 1, i);

                tableLayoutPanelValues.Controls.Add(new Label()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter
                }, 2, i);

                labelFirst = tableLayoutPanelValues.GetControlFromPosition(0, i).Text;
                labelSecond = tableLayoutPanelValues.GetControlFromPosition(1, i).Text;
                labelThird = tableLayoutPanelValues.GetControlFromPosition(2, i).Text;
                ReadMyFileSolution(ref labelFirst, ref labelSecond, ref labelThird, ref ID);
                tableLayoutPanelValues.GetControlFromPosition(0, i).Text = labelFirst;
                tableLayoutPanelValues.GetControlFromPosition(1, i).Text = labelSecond;
                tableLayoutPanelValues.GetControlFromPosition(2, i).Text = labelThird;
            }
        }
    }
}
