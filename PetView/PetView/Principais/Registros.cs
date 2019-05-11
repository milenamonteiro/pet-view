using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetView
{
    public partial class Registros : UserControl
    {
        public Registros()
        {
            InitializeComponent();
            CarregaCbo();
        }

        private void CarregaCbo()
        {
            List<string> tabelas = new List<string> { "Animal", "Dono", "Consulta", "Exame", "Funcionário", "Médico", "Tratamento" };
            tabelas.ForEach(item => cboTabelas.Items.Add(item));
            cboTabelas.SelectedIndex = -1;
        }

        string cboTabela_item;
        private void cboTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTabela_item != cboTabelas.SelectedItem.ToString())
            {
                cboTabela_item = cboTabelas.SelectedItem.ToString();
                change_cboColunas_items();
            }
        }

        private void dgvTabela(string nometab)
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("exec sp_select_" + nometab, con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvRegistros.DataSource = dtbl;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void change_cboColunas_items()
        {
            cboColunas.Items.Clear();
            switch (cboTabela_item)
            {
                case "":
                    break;

                case "Animal":
                    List<string> animal = new List<string> { "Código", "RGA", "Nome do dono", "Nome do animal", "Idade", "Raça", "Espécie", "Descrição" };
                    animal.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("animal");
                    break;

                case "Dono":
                    List<string> dono = new List<string> { "Código", "Nome", "CPF", "RG", "Telefone", "Celular", "Email" };
                    dono.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("dono");
                    break;

                case "Consulta":
                    List<string> consulta = new List<string> { "Código", "Nome do animal", "Nome do médico", "Nome do dono", "Custo", "Tipo", "Data" };
                    consulta.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("consulta");
                    break;

                case "Exame":
                    List<string> exame = new List<string> { "Código", "Nome do animal", "Nome do médico", "Nome do dono", "Custo", "Tipo", "Data" };
                    exame.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("exame");
                    break;

                case "Funcionário":
                    List<string> func = new List<string> { "Código", "Nome", "CPF", "RG", "Status", "Telefone", "Celular", "Email", "Cargo", "Salário" };
                    func.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("func");
                    break;

                case "Médico":
                    List<string> med = new List<string> { "Código", "CRMV", "Nome", "Função", "CPF", "RG", "Celular", "Telefone", "Email", "Status", "Salário" };
                    med.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("medico");
                    break;

                case "Tratamento":
                    List<string> tratamento = new List<string> { "Código", "Nome do animal", "Nome do médico", "Nome do dono", "Custo", "Tipo", "Data" };
                    tratamento.ForEach(item => cboColunas.Items.Add(item));
                    cboColunas.SelectedIndex = -1;
                    dgvTabela("tratamento");
                    break;
            }
        }

        private void dgvParametros(String tabela, String coluna, String valor)
        {
            switch (tabela)
            {
                case "Animal":
                    dgvRegistros.DataSource = Animal.Select(coluna, valor);
                    break;

                case "Dono":
                    dgvRegistros.DataSource = Dono.Select(coluna, valor);
                    break;

                case "Consulta":
                    dgvRegistros.DataSource = Consulta.Select(coluna, valor);
                    break;

                case "Exame":
                    dgvRegistros.DataSource = Exame.Select(coluna, valor);
                    break;

                case "Funcionário":
                    dgvRegistros.DataSource = Funcionario.Select(coluna, valor);
                    break;

                case "Médico":
                    dgvRegistros.DataSource = Medico.Select(coluna, valor);
                    break;

                case "Tratamento":
                    dgvRegistros.DataSource = Tratamento.Select(coluna, valor);
                    break;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgvParametros(cboTabelas.SelectedItem.ToString(), cboColunas.SelectedItem.ToString(), txtFiltro.Text);
        }

    }
}