using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TVP_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            fill fillForm= new fill();        
            fillForm.ShowDialog();
            label4.Text = Data.Value; 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fill fillForm = new fill();
            fillForm.ShowDialog();
            label5.Text = Data.Value;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fill fillForm = new fill();
            fillForm.ShowDialog();
            label6.Text = Data.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputData = "Faculty: " + label4.Text + "\n" + "Dean's Name: " + label5.Text + "\n" + "Abbreviation: " + label6.Text+"\n";
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "Input name of output file!";
            }
            File.AppendAllText(textBox1.Text, inputData); 
        }
    }
}
