using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVP_Task_1
{
    public partial class fill : Form
    {
        
        public fill()
        {
            InitializeComponent();
        }

        public fill(Form f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Value = FacultyBox.Text;
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
