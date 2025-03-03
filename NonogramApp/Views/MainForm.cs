using System;
using System.Windows.Forms;
using NonogramApp.Views; 

namespace NonogramApp.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler voor label1
        }

        private void Home_Click(object sender, EventArgs e)
        {
            // Event handler voor Home knop
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Event handler voor Login knop
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Event handler voor button1 (Speel Nu knop)
            SizeSelectionForm sizeSelectionForm = new SizeSelectionForm();
            sizeSelectionForm.ShowDialog();
        }
    }
}