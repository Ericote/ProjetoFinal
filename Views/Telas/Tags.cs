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
    public class Tags : Form
    {
		private System.ComponentModel.IContainer components = null;
        ListView lstTags;
		Button btnInserir;
		Button btnUpdate;
		Button btnDelete;
		Button btnVoltar;

        public Tags()
        {
            lstTags = new ListView();
			lstTags.Location = new Point(50,50 );
			lstTags.Size = new Size(400,320);
			lstTags.View = View.Details;
			ListViewItem tag1 = new ListViewItem(" 5");
			tag1.SubItems.Add("aaaaaaa");
			ListViewItem tag2 = new ListViewItem("3");
			tag2.SubItems.Add("aaaaaaa");
			ListViewItem tag3 = new ListViewItem("1");
			tag3.SubItems.Add("aaaaaa");		
			lstTags.Items.AddRange(new ListViewItem[]{tag1, tag2, tag3});
			lstTags.Columns.Add("ID", -2, HorizontalAlignment.Left);
			lstTags.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			lstTags.FullRowSelect = true;
			lstTags.GridLines = true;
			lstTags.AllowColumnReorder = true;
			lstTags.Sorting = SortOrder.Ascending;

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
            this.Controls.Add(this.lstTags);

			this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Tags";

			
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
				CadTags CadTags = new CadTags();
				CadTags.ShowDialog();
            } 

    }
}