using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetView
{
    public class Dono : ICadastro
    {
        public int CodigoDono { get; set; }
        public String NomeDono { get; set; }
        public String CPFDono { get; set; }
        public String RGDono { get; set; }
        public String CelDono { get; set; }
        public String TelDono { get; set; }
        public String EmailDono { get; set; }
        public Endereco endereco { get; set; }

        public Dono() { }

        public Dono(string nomeDono, string cPFDono, string rGDono, string celDono, string telDono, string emailDono, string cep, string bairro, string cidade, string complemento, int numcasa, string rua, string uf)
        {
            endereco = new Endereco();
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

            SqlCommand cmd = new SqlCommand("sp_insert_dono", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cep", SqlDbType.Char).Value = endereco.CEP;
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = endereco.NumCasa;
            cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = endereco.Rua;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = endereco.Bairro;
            if (string.IsNullOrWhiteSpace(endereco.Complemento))
                cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = SqlString.Null;
            else
                cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = endereco.Complemento;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = endereco.Cidade;
            cmd.Parameters.Add("@uf", SqlDbType.Char).Value = endereco.UF;
            cmd.Parameters.Add("@nome_dono", SqlDbType.VarChar).Value = NomeDono;
            cmd.Parameters.Add("@cpf_dono", SqlDbType.Char).Value = CPFDono;
            cmd.Parameters.Add("@rg_dono", SqlDbType.Char).Value = RGDono;
            if (string.IsNullOrWhiteSpace(TelDono))
                cmd.Parameters.Add("@tel_dono", SqlDbType.Char).Value = SqlString.Null;
            else
                cmd.Parameters.Add("@tel_dono", SqlDbType.Char).Value = TelDono;
            cmd.Parameters.Add("@cel_dono", SqlDbType.Char).Value = CelDono;
            if (string.IsNullOrWhiteSpace(EmailDono))
                cmd.Parameters.Add("@email_dono", SqlDbType.VarChar).Value = SqlString.Null;
            else
                cmd.Parameters.Add("@email_dono", SqlDbType.VarChar).Value = EmailDono;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dono registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
