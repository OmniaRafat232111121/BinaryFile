using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaryfile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            textBox1.Text = Class.filename;

        }


        private void button2_Click(object sender, EventArgs e)//back 
        {
            new Form1().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)// Save 

        {

            BinaryWriter BBB = new BinaryWriter(File.Open(Class.filename, FileMode.Open, FileAccess.Write)); // We Should include using System.IO
            int length = (int)BBB.BaseStream.Length;


            if (length == 0) // لو الفايل لفاضي أعمل أضافه في أول فايل
            {
                BBB.Write(int.Parse(textBox2.Text)); // ID 
                textBox3.Text = textBox3.Text.PadRight(9); // Name 
                BBB.Write(textBox3.Text.Substring(0, 9));

                textBox5.Text = textBox5.Text.PadRight(11);// AGE 
                BBB.Write(textBox5.Text.Substring(0, 11));


                BBB.Write(int.Parse(textBox4.Text));// Year 

                BBB.Write(textBox6.Text.Substring(0, 1)); // Gender 

                length += Class.rec_size;

            }
            else 
            {
                BBB.BaseStream.Seek(length, SeekOrigin.Begin);//  هيمشي 32 بايت وبعدين هيكتب  
                BBB.Write(int.Parse(textBox2.Text));
                textBox3.Text = textBox3.Text.PadRight(9);
                BBB.Write(textBox3.Text.Substring(0, 9));

                textBox4.Text = textBox4.Text.PadRight(11);
                BBB.Write(textBox4.Text.Substring(0, 11));


                BBB.Write(int.Parse(textBox5.Text));

                BBB.Write(textBox6.Text.Substring(0, 1));
                length += Class.rec_size;

            }

            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
            label7.Text = (length / Class.rec_size).ToString();//  عدد الريكورد
            label8.Text = length.ToString();// حجم الفايل
            MessageBox.Show("Data is saved successfully");
            BBB.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
