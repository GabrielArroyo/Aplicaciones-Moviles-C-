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

        public Form1()
        {
            InitializeComponent();
            hi[0] = checkBox1;
            hi[1] = checkBox2;
            hi[2] = checkBox3;
            hi[3] = checkBox4;
            hi[4] = checkBox5;
            hi[5] = checkBox6;
            hi[6] = checkBox7;
            hi[7] = checkBox8;
            hi[8] = checkBox9;
            hi[9] = checkBox10;
            hi[10] = checkBox11;
            hi[11] = checkBox12;
            hi[12] = checkBox13;
            hi[13] = checkBox14;
            hi[14] = checkBox15;
            hi[15] = checkBox16;
        }

        private void check(int x)
        {

            int max = 0;

            if (comboBox1.Text.Equals("SIMPLE"))
                max = 4;
            else if (comboBox1.Text.Equals("MÚLTIPLE"))
                max = 6;
            else if (comboBox1.Text.Equals("EXTREMA"))
                max = 8;

            if (max > 0)
            {

                if (hi[x].Checked)
                {
                    if (total <= max)
                        total++;
                }

                if (!hi[x].Checked)
                {
                    total--;
                }


                if (total > max)
                    hi[x].Checked = false;

                if (total == max + 1)
                    total = max;

            }
        }

        public void rellenar()
        {
            total = 0;
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
            Random che = new Random();
            int a = che.Next(1, 16);
            if (radioButton2.Checked == true)
                panel2.Enabled = false;

            if (comboBox1.SelectedIndex == 0)
            {
                while (total < 4)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        total++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        total++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        total++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        total++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        total++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        total++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        total++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        total++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        total++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        total++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        total++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        total++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        total++;
                    }

                    a = che.Next(1, 16);

                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                while (total < 6)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        total++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        total++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        total++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        total++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        total++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        total++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        total++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        total++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        total++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        total++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        total++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        total++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        total++;
                    }

                    a = che.Next(1, 16);

                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                while (total < 8)
                {


                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 2 && checkBox2.Checked != true)
                    {
                        checkBox2.Checked = true;
                        total++;
                    }
                    else
                    if (a == 3 && checkBox3.Checked != true)
                    {
                        checkBox3.Checked = true;
                        total++;
                    }
                    else
                    if (a == 4 && checkBox4.Checked != true)
                    {
                        checkBox4.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 5 && checkBox5.Checked != true)
                    {
                        checkBox5.Checked = true;
                        total++;
                    }
                    else
                    if (a == 1 && checkBox1.Checked != true)
                    {
                        checkBox1.Checked = true;
                        total++;
                    }
                    else
                    if (a == 6 && checkBox6.Checked != true)
                    {
                        checkBox6.Checked = true;
                        total++;
                    }
                    else
                    if (a == 7 && checkBox7.Checked != true)
                    {
                        checkBox7.Checked = true;
                        total++;
                    }
                    else
                    if (a == 8 && checkBox8.Checked != true)
                    {
                        checkBox8.Checked = true;
                        total++;
                    }
                    else
                    if (a == 9 && checkBox9.Checked != true)
                    {
                        checkBox9.Checked = true;
                        total++;
                    }
                    else
                    if (a == 10 && checkBox10.Checked != true)
                    {
                        checkBox10.Checked = true;
                        total++;
                    }
                    else
                    if (a == 11 && checkBox11.Checked != true)
                    {
                        checkBox11.Checked = true;
                        total++;
                    }
                    else
                    if (a == 12 && checkBox12.Checked != true)
                    {
                        checkBox12.Checked = true;
                        total++;
                    }
                    else
                    if (a == 13 && checkBox13.Checked != true)
                    {
                        checkBox13.Checked = true;
                        total++;
                    }
                    else
                    if (a == 14 && checkBox14.Checked != true)
                    {
                        checkBox14.Checked = true;
                        total++;
                    }
                    else
                    if (a == 15 && checkBox15.Checked != true)
                    {
                        checkBox15.Checked = true;
                        total++;
                    }
                    else
                    if (a == 16 && checkBox16.Checked != true)
                    {
                        checkBox16.Checked = true;
                        total++;
                    }

                    a = che.Next(1, 16);

                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            total = 0;
            Random i = new Random();
            textBox1.Text = Convert.ToString(i.Next(1,10));
            panel1.Enabled = true;
            if (radioButton2.Checked == false)
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
        private void che1(object sender, EventArgs e) { check(0); }
        private void che2(object sender, EventArgs e) { check(1); }
        private void che3(object sender, EventArgs e) { check(2); }
        private void che4(object sender, EventArgs e) { check(3); }
        private void che5(object sender, EventArgs e) { check(4); }
        private void che6(object sender, EventArgs e) { check(5); }
        private void che7(object sender, EventArgs e) { check(6); }
        private void che8(object sender, EventArgs e) { check(7); }
        private void che9(object sender, EventArgs e) { check(8); }
        private void che10(object sender, EventArgs e) { check(9); }
        private void che11(object sender, EventArgs e) { check(10); }
        private void che12(object sender, EventArgs e) { check(11); }
        private void che13(object sender, EventArgs e) { check(12); }
        private void che14(object sender, EventArgs e) { check(13); }
        private void che15(object sender, EventArgs e) { check(14); }
        private void che16(object sender, EventArgs e) { check(15); }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rellenar();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0 && total < 4)
            {
                string mensage = "Numeros incorrectos";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
            }else if(comboBox1.SelectedIndex == 1 && total < 6)
            {
                string mensage = "Numeros incorrectos";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
            }else if(comboBox1.SelectedIndex == 2 && total < 8)
            {
                string mensage = "Numeros incorrectos";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.AddRange(new object[] { "Nº de reintegro" + textBox1.Text });


                for (int i = 0; i < hi.Length; i++)
                {
                    if (hi[i].Checked)
                    {
                        listBox1.Items.AddRange(new object[] { "Número" + hi[i].Text });
                    }
                }

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

                comboBox1.SelectedIndex = -1;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                panel1.Enabled = false;
                panel2.Enabled = false;
                dateTimePicker1.Enabled = false;
                button1.Enabled = false;
            }
        }
        private void Apostar_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            listBox1.Items.Clear();
        }
    }
}
