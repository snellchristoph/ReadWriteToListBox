using System.IO;
using System;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _315_proj_sol1


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text files|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader read = new StreamReader(ofd.FileName))
                    {
                        string line;

                        while ((line = read.ReadLine()) != null)
                        {
                            txtText.AppendText(line + Environment.NewLine);
                        }
                        read.Close();
                    }
                }
            }
        }                                       

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            if (txtText.Text.Length == 0)
            {
                MessageBox.Show("There is no text to write.", "Error");
                return;
            }

            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog2.FileName;

                StreamWriter sw = new StreamWriter(fileName);

                sw.Write(txtText.Text);

                sw.Close();

                MessageBox.Show("The file has been updated.", "Success");
            }
        }
    }
    }