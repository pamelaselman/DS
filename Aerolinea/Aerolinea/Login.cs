﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PROGRAMADOR Y ANALISTA: Gerardo Santizo
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 09/Agosto/2015
namespace Aerolinea
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (claseUsuario.Autentificar(txtUser.Text, txtPass.Text) > 0)
            {
               //VALIDACIÓN DE USUARIO ADMINISTRADOR
                if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Admin"))
                {
                    this.Hide();
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    MessageBox.Show(claseUsuario.user(txtUser.Text, txtPass.Text));
                }   
                    //VALIDACIÓN DE USUARIO NORMAL (PERMISOS BÁSICOS DE INSERTAR Y CONSULTAR)
                else if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Normal"))
                {
                    this.Hide();
                    frmMenu MenuNormal = new frmMenu();
                    MenuNormal.Show();
                  MessageBox.Show(claseUsuario.user(txtUser.Text, txtPass.Text));
                }
                    //VALIDACIÓN USUARIO QUE ACCEDE A INFORMACIÓN DE VUELOS
                else if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Vuelos")){
                    this.Hide();
                    frmMenu MenuVuelos = new frmMenu();
                    MenuVuelos.Show();
                    MessageBox.Show(claseUsuario.user(txtUser.Text, txtPass.Text));
                }
                //this.Hide();
                //Menu menu = new Menu();
                //menu.Show();
            }
            else
                MessageBox.Show("Usario o Password Incorrecto, Vuelva a Intentarlo");
                txtUser.Clear();
                txtPass.Clear();
        }
    }
}
