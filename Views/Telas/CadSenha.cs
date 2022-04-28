using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public class CadSenha : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblNome;
        Label lblCategoria;
        Label lblUrl;
        Label lblUser;
        Label lblSenha;
        Label lblProcedimento;
        Label lblTag;
        
        TextBox txtNome;
        TextBox txtCategoria;
        TextBox txtUrl;
        TextBox txtUser;
        TextBox txtSenha;
        TextBox txtProcedimento;
        
        Button btnConfirmar;
        Button btnCancelar;

        public CadSenha()
        {

            //========== Label e Box do nome =============

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(130, 10);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(60, 40);
            this.txtNome.Size = new Size(180, 20);

            //========== Label e Box Categoria ============

            this.lblCategoria = new Label();
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Location = new Point(120, 65);

            this.txtCategoria = new TextBox();
            this.txtCategoria.Location = new Point(60, 90);
            this.txtCategoria.Size = new Size(180, 20);

            //========== Label e Box do Url =============

            this.lblUrl = new Label();
            this.lblUrl.Text = "Url";
            this.lblUrl.Location = new Point(140, 115);

            this.txtUrl = new TextBox();
            this.txtUrl.Location = new Point(60, 140);
            this.txtUrl.Size = new Size(180, 20);

            //========== Label e Box de Usuário ===========

            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(130, 165);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(60, 190);
            this.txtUser.Size = new Size(180, 20);

            //========== Label e Box do SENHA =============

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 215);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(60, 240);
            this.txtSenha.Size = new Size(180, 20);

            //=========== Procedimento ==============

            this.lblProcedimento = new Label();
            this.lblProcedimento.Text = "Procedimento";
            this.lblProcedimento.Location = new Point(110, 265);

            this.txtProcedimento = new TextBox();
            this.txtProcedimento.Location = new Point(60, 290);
            this.txtProcedimento.Size = new Size(180, 200);

            //============ Tags =====================

            this.lblTag = new Label();
            this.lblTag.Text = "Tags";
            this.lblTag.Location = new Point(130, 340);

            //=========== Confirmar =============

            this.btnConfirmar = new ButtonField("Confirmar", 100, 615, 100, 30);
            btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

            //========== Cancelar ===============

            this.btnCancelar = new ButtonField("Cancelar",100, 650,100, 30);
            btnCancelar.Click += new EventHandler(this.btnCancelarClick);


            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblProcedimento);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtProcedimento);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 700);
            this.Text = "Cadastro Senha";
        }

        private void btnCancelarClick(object sender, EventArgs e)
           {
                this.Close();
           }

           public void btnConfirmarClick(object sender, EventArgs e)
        {
            string message = "Senha cadastrada com sucesso! (Só que não, isso aqui é teste)";
            string caption = " PARABÉNS ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            
            	this.Close();

           }

        }
    }
}