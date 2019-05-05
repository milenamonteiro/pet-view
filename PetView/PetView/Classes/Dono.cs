using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Dono : ICadastro
    {
        public int CodigoDono { get; set; }
        public String NomeDono { get; set; }
        public char CPFDono { get; set; }
        public char RGDono { get; set; }
        public char CelDono { get; set; }
        public char TelDono { get; set; }
        public String EmailDono { get; set; }
        public Endereco endereco { get; set; }

        public Dono(string nomeDono, char cPFDono, char rGDono, char celDono, char telDono, string emailDono, string cep, string bairro, string cidade, string complemento, int numcasa, string rua, string uf)
        {
            NomeDono = nomeDono;
            CPFDono = cPFDono;
            RGDono = rGDono;
            CelDono = celDono;
            TelDono = telDono;
            EmailDono = emailDono;
            endereco.CEP = cep;
            endereco.Bairro = bairro;
            endereco.Cidade = cidade;
            endereco.Complemento = complemento;
            endereco.NumCasa = numcasa;
            endereco.Rua = rua;
            endereco.UF = uf;
        }

        public void Insert()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("sp_insert_animal", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@rga", SqlDbType.Int).Value = (object)RGA ?? DBNull.Value;
            cmd.Parameters.Add("@cod_dono", SqlDbType.Int).Value = dono.CodigoDono;
            cmd.Parameters.Add("@nome_animal", SqlDbType.VarChar).Value = NomeAnimal;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = IdadeAnimal;
            cmd.Parameters.Add("@tipo_idade", SqlDbType.VarChar).Value = Tempo;
            cmd.Parameters.Add("@raca_animal", SqlDbType.VarChar).Value = Raca;
            cmd.Parameters.Add("@especie", SqlDbType.VarChar).Value = Especie;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = Descricao;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Animal registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro: " + e.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void Update() { }
        public void Delete() { }
    }
}
