/*
 * Criado por SharpDevelop.
 * Usuário: Aluno_Manha
 * Data: 20/02/2025
 * Hora: 08:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Questão_A
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnclick;
		private System.Windows.Forms.Label lblMensagem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnclick = new System.Windows.Forms.Button();
			this.lblMensagem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnclick
			// 
			this.btnclick.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnclick.Location = new System.Drawing.Point(56, 87);
			this.btnclick.Name = "btnclick";
			this.btnclick.Size = new System.Drawing.Size(175, 43);
			this.btnclick.TabIndex = 0;
			this.btnclick.Text = "Clique Aqui";
			this.btnclick.UseVisualStyleBackColor = false;
			this.btnclick.Click += new System.EventHandler(this.BtnclickClick);
			// 
			// lblMensagem
			// 
			this.lblMensagem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.Location = new System.Drawing.Point(99, 133);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(100, 23);
			this.lblMensagem.TabIndex = 1;
			this.lblMensagem.Click += new System.EventHandler(this.LblMensagemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblMensagem);
			this.Controls.Add(this.btnclick);
			this.Name = "MainForm";
			this.Text = "Questão A";
			this.ResumeLayout(false);

		}
	}
}
