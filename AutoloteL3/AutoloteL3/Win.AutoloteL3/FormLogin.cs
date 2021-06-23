﻿using BL.Ventas;
using System;
using System.Windows.Forms;

namespace Win.AutoloteL3
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
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

            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true )
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