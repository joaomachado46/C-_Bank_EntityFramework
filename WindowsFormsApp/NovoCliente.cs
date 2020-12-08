using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new BankContext())
                {
                    var NovoTitular = new TitularConta()
                    {
                        Nome = textBoxNomeCliente.Text,
                        Morada = textBoxMorada.Text,
                        Cidade = textBoxCidade.Text,
                        Email = textBoxEmail.Text,
                        Senha = int.Parse(textBoxSenha.Text),
                    };

                    contexto.Add(NovoTitular);
                    contexto.SaveChanges();
                }
                MessageBox.Show("Registo Efetuado com sucesso. Obrigado");
                PaginaPrincipal nova = new PaginaPrincipal();
                nova.reiniciar();

                Close();
            }catch (Exception)
            {
                MessageBox.Show("Erro, preencha todos os dados");
            }
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
