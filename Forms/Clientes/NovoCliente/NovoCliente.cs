using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistemaEstoqueLogin.Forms.Clientes
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        public bool ValidarCpf(string cpf)
        {
            // Remove caracteres especiais, deixando só os números
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais (CPF inválido)
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            // Cálculo do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            // Cálculo do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            // Verifica se os dígitos calculados são iguais aos dígitos informados
            return cpf[9] == digito1 + '0' && cpf[10] == digito2 + '0';
        }

        private void txtCpfNovoCliente_Leave(object sender, EventArgs e)
        {

        }

        public async Task BuscarEnderecoPorCep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    JObject endereco = JObject.Parse(jsonResult);

                    // Verificar se o CEP foi encontrado
                    if (endereco["erro"] != null)
                    {
                        MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Preencher os campos da interface com os dados do endereço
                    txtEnderecoNovoCliente.Text = endereco["logradouro"].ToString();
                    txtCidadeNovoCliente.Text = endereco["localidade"].ToString();
                    txtUfNovoCliente.Text = endereco["uf"].ToString();
                }
                else
                {
                    MessageBox.Show("Erro ao buscar o CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void txtCepNovoCliente_Leave(object sender, EventArgs e)
        {
            string cep = txtCepNovoCliente.Text.Replace("-", ""); // Remove traço, se houver
            if (cep.Length == 8) // Verifica se o CEP tem 8 dígitos
            {
                await BuscarEnderecoPorCep(cep);
            }
            else
            {
                MessageBox.Show("CEP inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCepNovoCliente.Focus();
            }
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarNovoCliente_Click(object sender, EventArgs e)
        {
            // Pega os dados dos TextBoxes
            string cpf = txtCpfNovoCliente.Text;
            string nome = txtNomeNovoCliente.Text;
            string cep = txtCepNovoCliente.Text;
            string cidade = txtCidadeNovoCliente.Text;
            string uf = txtUfNovoCliente.Text;
            string endereco = txtEnderecoNovoCliente.Text;
            string numero = txtNumeroNovoCliente.Text;
            string email = txtEmailNovoCliente.Text;
            string telefone = txtTelefoneNovoCliente.Text;

            try
            {
                // Chama a função para salvar o cliente no banco de dados
                BancoDeDados.SalvarCliente(cpf, nome, cep, cidade, uf, endereco, numero, email, telefone);

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Cliente salvo com sucesso!");

                // Retorna para a tela de clientes
                TelaClientes telaClientes = new TelaClientes();
                telaClientes.Show();
                this.Close();  // Fecha a tela atual (NovoCliente)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cliente: " + ex.Message);
            }
        }
    }
}
