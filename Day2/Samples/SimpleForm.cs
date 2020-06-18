using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleForm
{
    public partial class Form1 : Form
    {
        TextBox textBox1 = new TextBox();

        public Form1()
        {
            //This method connects our code to
            //the one from the designer
            InitializeComponent();
        }

        void button1_clicked(object sender, EventArgs e)
        {
            //A simple possibility for displaying output is the
            //MessageBox.Show() method
            //textBox1 is a TextBox instance, which has a property
            //called Text - this given us access to its value
            MessageBox.Show(textBox1.Text);
        }
    }
}