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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Class.filename;
        }

        private void Display_Click(object sender, EventArgs e)
        {

            BinaryReader b = new BinaryReader(File.Open(Class.filename, FileMode.Open, FileAccess.Read));
            int num_of_records = (int)b.BaseStream.Length / Class.rec_size;
            if (num_of_records > 0) // If The file Not Empty
            {
                Display.Text = "Next";// Change the Button Text
                label7.Text = num_of_records.ToString(); // Number of Records Label
                label8.Text = b.BaseStream.Length.ToString(); // File Size Lable
                b.BaseStream.Seek(Class.count, SeekOrigin.Begin); // Move to Specific Position in a File

                textBox2.Text = b.ReadInt32().ToString(); // Read ID and display it in the textbox2

                textBox3.Text = b.ReadString(); // Read Name 
                textBox4.Text = b.ReadString(); // Read Tel
                textBox5.Text = b.ReadInt32().ToString(); // Read Year

                textBox6.Text = b.ReadString(); // Read Gender


                if ((Class.count / Class.rec_size) >= (num_of_records - 1)) // If I reach the End of file , Go to the Beginning of file
                    Class.count = 0;
                else
                    Class.count += Class.rec_size;

            }
            else MessageBox.Show("Empty File");
            b.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
