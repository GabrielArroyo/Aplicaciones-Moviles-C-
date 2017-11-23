using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        private int total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void rellenar()
        {
            int cont = 0;
            Random che = new Random();
            int a = che.Next(1, 16);
            if (radioButton2.Checked == true)
                panel2.Enabled = false;

            if (comboBox1.SelectedIndex == 0)
            {
                while (cont < 4)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        cont++;
                    }

                    a = che.Next(1, 16);

                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                while (cont < 6)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        cont++;
                    }

                    a = che.Next(1, 16);

                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                while (cont < 8)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        cont++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        cont++;
                    }

                    a = che.Next(1, 16);

                }
            }







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random i = new Random();
            textBox1.Text = Convert.ToString(i.Next(1,10));
            panel1.Enabled = true;
            if (radioButton2.Checked == false)
            {
                panel2.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                rellenar();
            }
            dateTimePicker1.Enabled = true;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker hoy = new DateTimePicker();
            hoy.MaxDate = DateTime.Today;
            if (dateTimePicker1.Value < hoy.MaxDate)
            {
                string mensage = "Fecha incorrecta";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
                dateTimePicker1.Text = null;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string mensage = "¿Realmente desea salir ?";
            string titulo = "Salir";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensage, titulo, opciones,
            MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                panel2.Enabled = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rellenar();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && total <= 4)
            {
                checkBox1.Checked = true;
                total++;
            }
            else if(total >= 5)
            {

                checkBox1.Checked = false;
            }else
            {
                total--;
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false && total <= 4)
            {
                checkBox2.Checked = true;
                total++;
            }
            else if (total >= 5)
            {
                checkBox2.Checked = false;
            }
            else
            {
                total--;
            }
        }
      
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false && total <= 4)
            {
                checkBox3.Checked = true;
                total++;
            }
            else if (total >= 5)
            {
                checkBox1.Checked = true;
                checkBox3.Checked = false;
            }
            else
            {
                total--;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false && total <= 4)
            {
                checkBox4.Checked = true;
                total++;
            }
            else if (total >= 5)
            {
                checkBox4.Checked = false;
            }
            else
            {
                total--;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false && total <= 4)
            {
                checkBox5.Checked = true;
                total++;
            }
            else if (total >= 5)
            {
                checkBox5.Checked = false;
            }
            else
            {
                total--;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == false && total <= 4)
            {
                checkBox6.Checked = true;
                total++;
            }
            else if (total >= 5)
            {
                checkBox6.Checked = false;
            }
            else
            {
                total--;
            }
        }

        
    }
}
