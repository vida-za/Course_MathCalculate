using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_MathCalculate
{
    public partial class HistoryForm : Form
    {
        MainForm mainForm;
        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(MainForm prevForm)
        {
            InitializeComponent();
            mainForm = prevForm;
        }

        private void buttonBack_Click(object sender, EventArgs e) 
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
