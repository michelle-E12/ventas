﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.AutoloteL3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                this.Close();
            }
            else
            if (usuario == "admin2" && contrasena == "0000")
                {
                this.Close();
            }
            else
            {
                MessageBox.Show("Ususario o contrasena incorrecta");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}