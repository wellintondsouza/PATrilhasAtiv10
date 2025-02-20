/*
 * Criado por SharpDevelop.
 * Usuário: Aluno_Manha
 * Data: 20/02/2025
 * Hora: 08:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Questão_A
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnclickClick(object sender, EventArgs e)
		{
			lblMensagem.Text = "Olá Mundo!";
			btnclick.Hide();
		}
		void LblMensagemClick(object sender, EventArgs e)
		{
	
		}
	}
}
