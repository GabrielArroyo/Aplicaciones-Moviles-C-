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
    public partial class Form2 : Form
    {
        string user = null;
        char [] pass = new char[20];
        string pass1;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox1.Text = null;
            dateTimePicker1.Text = null;
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass1 = textBox1.Text;
            bool verdadero = false;
            DateTimePicker hoy = new DateTimePicker();
            hoy.MinDate = Convert.ToDateTime("23-11-1999");
            string [] final = null;
            string respaldo = null;
            string comp = "gmail.com";
            char[] op = { '+', '-', '*', '/' };
            user = textBox2.Text;


            for (int i = 0; i < user.Length; i++)
                final = user.Split('@');

            for (int i = 0; i < final.Length; i++)
               respaldo += final[i];

            /*
             for (int i = 0; i < pass.Length; i++)
             {
                 pass[i] = Convert.ToChar(textBox1.Text[i]);
                 for (int j = 0; j < op.Length; j++)
                 {
                     if(op[j] == pass[i])
                     {
                         verdadero = true;

                     }


                 }


             }
              */
            /*
            for(int i = 0; i < user.Length; i++)
            {
                int j = i;
                if (user[i].Equals(respaldo))
                {
                    while (j < user.Length)
                    {
                        final += user[j++];
                    }
                    
                }
            }
            */
            if (respaldo == comp)
            {
                string mensage = "Error de usuario";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);

            } else
            if (dateTimePicker1.Value > hoy.MinDate)
            {
                string mensage = "Fecha incorrecta";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
                dateTimePicker1.Text = null;
            } else
            if (!verdadero)
            {
                string mensage = "Error de Contraseña";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);
            }
            else if (pictureBox1.Image == null)
            {
                string mensage = "No hay imagen";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);

            }



            textBox2.Text = null;
            textBox1.Text = null;
            dateTimePicker1.Text = null;
            pictureBox1.Image = null;
            groupBox3.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            checkBox1.Checked = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox5.Text = textBox4.Text;
            else
                textBox5.Text = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                textBox5.Text = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == user && textBox4.Text == pass1)
            {
                string mensage = "Login correcto";
                string titulo = "Correcto";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Information);
                this.Visible = false;
                Form1 a = new Form1();
                a.Show();
            }
            else
            {
                string mensage = "Login incorrecto";
                string titulo = "ERROR";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones,
                MessageBoxIcon.Error);



            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
