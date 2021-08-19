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

namespace binaryfile
{
  
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Create Button
        {
            Class.filename = " D:\\" + textBox1.Text + ".txt"; // Get the file name from user if I insert file1 in textbox1 ,filename= E:\\file1.txt
            if (!File.Exists(Class.filename)) // if the file does not exists 
                {
                    File.Create(Class.filename).Close();// We Should include using System.IO;
                    MessageBox.Show("File is created");
                }
            else
                label2.Visible = true; // Error Message “ File Exists “ should set Lable2 : visible = false from properties window first
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // Exit 
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // Delete 
        {
            Class.filename = " D:\\" + textBox1.Text + ".txt"; // Get the file name from user if I insert file1 in textbox1 ,filename= E:\\file1.txt
            File.Delete(Class.filename);
            MessageBox.Show("File is Deleted");


        }

        private void button3_Click(object sender, EventArgs e) // Insert 
        {
            new Form2().Show();// Open Form 2
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            }
        }
    }
  

