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
    public class Senhas : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstSenhas;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public Senhas()
        {
            lstSenhas = new ListView();
			lstSenhas.Location = new Point(50,50 );
			lstSenhas.Size = new Size(400,320);
			lstSenhas.View = View.Details;
			ListViewItem categoria1 = new ListViewItem(" 5");
			categoria1.SubItems.Add("Teste1");
			categoria1.SubItems.Add("sim");
			categoria1.SubItems.Add("teste1.com");
			ListViewItem categoria2 = new ListViewItem("3");
			categoria2.SubItems.Add("Teste2");
			categoria2.SubItems.Add("aham");
			categoria2.SubItems.Add("teste2.com");
			ListViewItem categoria3 = new ListViewItem("1");
			categoria3.SubItems.Add("Teste3");	
			categoria3.SubItems.Add("aquela lá");
			categoria3.SubItems.Add("teste3.com");		
			lstSenhas.Items.AddRange(new ListViewItem[]{categoria1, categoria2, categoria3});
			lstSenhas.Columns.Add("ID", -2, HorizontalAlignment.Left);
    		lstSenhas.Columns.Add("Nome", -2, HorizontalAlignment.Left);
			lstSenhas.Columns.Add("Categoria", -2, HorizontalAlignment.Left);
			lstSenhas.Columns.Add("Url", -2, HorizontalAlignment.Left);
			lstSenhas.FullRowSelect = true;
			lstSenhas.GridLines = true;
			lstSenhas.AllowColumnReorder = true;
			lstSenhas.Sorting = SortOrder.Ascending;

			//============= Inserir ===============

			this.btnInserir = new ButtonField("Inserir", 50, 380,100, 30);
			btnInserir.Click += new EventHandler(this.btnInserirClick);

			//================ Update ==================

			this.btnUpdate = new ButtonField("Update", 150, 380, 100, 30);

			//================= Delete =====================

			this.btnDelete = new ButtonField("Delete", 250, 380, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

			//================= Voltar =================

			this.btnVoltar = new ButtonField("Voltar", 350, 380, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstSenhas);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Senhas";

			
        }

			private void btnVoltarClick(object sender, EventArgs e)
           {
            	this.Close();
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

		public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Você realmente deseja excluir o item 1?";
            string caption = " EXCLUIR ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
           {
            	this.Close();
           }

        }

		private void btnInserirClick(object sender, EventArgs e)
            {
            
				CadSenha CadSenha = new CadSenha();
				CadSenha.ShowDialog();
            }
			
    }
}