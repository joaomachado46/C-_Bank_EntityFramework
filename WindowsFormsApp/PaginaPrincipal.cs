using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PaginaPrincipal : Form
    {
        

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCliente.Hide();
            panelEmprestimo.Hide();
            panelLevantamento.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BankContext())
                {
                    TitularConta titularAtri = null;
                    if (textBoxEmail.Text == "" || textBoxSenha.Text == "")
                        MessageBox.Show("Preencha todos os dados");
                    else
                    {
                        foreach (TitularConta titular in context.TitularContas)
                        {
                            if (titular.Email == textBoxEmail.Text)
                            {
                                titularAtri = titular;
                            }
                        }

                        if (titularAtri.Email != textBoxEmail.Text || titularAtri.Senha != int.Parse(textBoxSenha.Text))
                        {
                            MessageBox.Show("Email ou Password incorreta!");
                        }

                        else if (titularAtri.Email == textBoxEmail.Text && titularAtri.Senha == int.Parse(textBoxSenha.Text))
                        {

                            panelCliente.Show();

                            textBoxDadosCliente.Text = titularAtri.ToString();
                        }

                        var cartoes = context.Cartoes.Include(a => a.CartoesTitulares)
                                                .ThenInclude(a => a.TitularConta)
                                                    .ToList();

                        foreach (var cartao in cartoes)
                        {
                            foreach (var cart in cartao.CartoesTitulares.Select(e => e.TitularConta.Id == titularAtri.Id))
                            {
                                textBoxDadosCliente.Text += cartao.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }


        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoCliente novo = new NovoCliente();
            novo.Show();
            panelCliente.Hide();
            textBoxEmail.ResetText();
            textBoxSenha.ResetText();
        }

        public void reiniciar()
        {
            Refresh();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {

            panelEmprestimo.Show();
            panelLevantamento.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();

            using (var contexto = new BankContext())
            {
                TitularConta titularContaEmprestimo = null;
                foreach (var titular in contexto.TitularContas)
                {
                    if (titular.Email == textBoxEmailEmprestimo.Text)
                    {
                        titularContaEmprestimo = titular;
                    }
                }
                var tipoDeConta = new TipoDeConta()
                {
                    NomeConta = comboBoxTipoEmprestimo.Text,
                };
                var cartao = new Cartao()
                {
                    Saldo = int.Parse(textBoxValor.Text),
                    NumeroCartao = numAleatorio.Next(10000, 20000000),
                    DataValidade = DateTime.Now.AddYears(10),
                    Nome = comboBoxTipoEmprestimo.Text,
                    TipoDeConta = tipoDeConta,
                };

                var CartaoTitular = new CartaoTitular()
                {
                    Cartao = cartao,
                    TitularConta = titularContaEmprestimo,
                };
                contexto.Add(CartaoTitular);

                var emprestimo = new Emprestimo()
                {
                    TipoEmprestimo = comboBoxTipoEmprestimo.Text,
                    Mensalidade = int.Parse(comboBoxMeses.Text),
                    NumeroContrato = numAleatorio.Next(1, 5000),
                    Cartao = cartao,
                    TitularConta = titularContaEmprestimo,
                };

                contexto.AddRange(emprestimo);
                contexto.SaveChanges();
            }
            MessageBox.Show("Empréstimo Realizado. \nEfectue novamente Login para actualizar. Obrigado");
            panelEmprestimo.Hide();


        }

        private void btnLevantamento_Click(object sender, EventArgs e)
        {


            panelLevantamento.Show();
            panelEmprestimo.Hide();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new BankContext())
                {
                    var cartao = new Cartao();
                    double saldo = 0.0;
                    Cartao cartao1 = null;
                    Movimento movimento1 = null;
                    foreach (var item in contexto.Cartoes)
                    {
                        if (item.NumeroCartao == int.Parse(textBoxNumCartaoMov.Text))
                        {
                            saldo = item.Saldo;
                            cartao1 = item;
                        }
                    }
                    if (textBoxDeposito.Text == "")
                    {
                        movimento1 = new Movimento()
                        {
                            Levantamento = int.Parse(textBoxLevantamento.Text),
                            ValorSaldo = saldo,
                            Cartao = cartao1,
                        };
                        if (saldo <= 0.0 || int.Parse(textBoxLevantamento.Text) > saldo)
                            MessageBox.Show("Não tem saldo suficite");
                        else
                        {
                            saldo = movimento1.LevantamentoConta();
                            MessageBox.Show("Movimento efectuado com sucesso. \nEfectue novamente o Login para actualizar os dados. \nObrigado");
                        }
                        textBoxLevantamento.ResetText();
                    }
                    else if (textBoxLevantamento.Text == "")
                    {
                        movimento1 = new Movimento()
                        {
                            Deposito = int.Parse(textBoxDeposito.Text),
                            ValorSaldo = saldo,
                            Cartao = cartao1,
                        };
                        saldo = movimento1.DepositoConta();
                        MessageBox.Show("Movimento efectuado com sucesso. \nEfectue novamente o Login para actualizar os dados. \nObrigado");
                        textBoxDeposito.ResetText();
                    }

                    var dados = contexto.Cartoes.First(cartao => cartao.NumeroCartao == int.Parse(textBoxNumCartaoMov.Text));

                    dados.Saldo = saldo;

                    contexto.AddRange(movimento1);
                    contexto.SaveChanges();
                }


            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCliente.Hide();
            textBoxEmail.ResetText();
            textBoxSenha.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var contexto = new BankContext())
            {
                foreach (var item in contexto.Movimentos.Include("Cartao"))
                {
                    if (item.Cartao.NumeroCartao == int.Parse(textBoxNumCartaoMov.Text))
                    {
                        textBoxMov.Text += item.ToString();
                    }
                }
            }
        }
    }
}
