﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Telas
{
    public class Login : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPassword;
        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;
        Button btnCadastrar;

        public Login()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            // 60 é larura e 40 é altura
            this.lblUser.Location = new Point(125, 30);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(60, 60);
            this.txtUser.Size = new Size(180, 20);

            //================ SENHA ====================

            this.lblPassword = new Label();
            this.lblPassword.Text = " Senha ";
            this.lblPassword.Location = new Point(125, 100);
            

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(60, 130);
            this.txtPass.Size = new Size(180, 20);
            this.txtPass.PasswordChar = '*';

            //============== BOTÕES ==================

            this.btnConfirm = new ButtonField("Confirmar", 100, 170, 100, 30);
            btnConfirm.Click += new EventHandler(this.btnConfirmarClick);

            this.btnCancel = new ButtonField("Cancelar",100,230,100, 30);
            btnCancel.Click += new EventHandler(this.btnCancelarClick);

            this.btnCadastrar = new ButtonField("Cadastre-se",100, 200,100, 30);
            btnCadastrar.Click += new EventHandler(this.btnCadastrarClick);

            //==================================  

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCadastrar);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
        }

        private void btnConfirmarClick(object sender, EventArgs e)
        {   
            try
            {
                Usuario.Auth(this.txtUser.Text, this.txtPass.Text);
                if(Usuario.UsuarioAuth != null)
                {
                    Menu Menus = new Menu();
                    Menus.ShowDialog(); 
                }
            }
            catch(Exception)
            {
                string message = "Email ou senha inválidos, tente novamente";
                string caption = "Atenção";
                MessageBox.Show(message, caption);
            }
                
        }  

        private void btnCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        } 

          public void btnCadastrarClick(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
			cadUsuario.ShowDialog();
        }

    }

    public class LabelField : Label 
    {
            public LabelField(string Text, int x, int y)
            {
                this.Text = Text;
                this.Location = new Point(x ,y);
            }
    }

    public class ButtonField : Button 
    {
            public ButtonField(string Text, int x, int y, int Z, int P)
            {
                this.Text = Text;
                this.Location = new Point(x ,y);
                this.Size = new Size(Z, P);
            }
    }

    }
