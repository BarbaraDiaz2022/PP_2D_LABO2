﻿using BibliotecaDeClases;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_VendedorCliente
{
    public partial class Frm_LoginCliente : Form
    {
        private const string ususarioClienteReal = "cliente@gmail.com";
        private const string passwordClienteReal = "cliente123";
        public Frm_LoginCliente()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            string password = this.textBox2.Text;

            SoundPlayer sonidoLogueo = new SoundPlayer();
            sonidoLogueo.SoundLocation = "C:/Users/GAMER ASUS/Downloads/logueo_1.wav";
            sonidoLogueo.Play();
            this.Hide();
            if (usuario == ususarioClienteReal && password == passwordClienteReal)
            {
                Frm_Ventas frm = new Frm_Ventas();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El correo o la contraseña no son correctos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Frm_LoginCliente frm = new Frm_LoginCliente();
                frm.Show();
                if (rbAutocompletar.Checked)
                {
                    textBox1.Text = ususarioClienteReal;
                    textBox2.Text = passwordClienteReal;
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                textBox1.Focus();
            }
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
        private void rbAutocompletar_CheckedChanged(object sender, EventArgs e)
        { 
            textBox1.Text = ususarioClienteReal;
            textBox2.Text = passwordClienteReal;
            string mensaje = Cliente.RetornarSaludo();
            MessageBox.Show(mensaje, "Bienvenido", MessageBoxButtons.OK);
        }
    }
}
