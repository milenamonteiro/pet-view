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
    public class Animal : ICadastro
    {
        public int CodigoAnimal { get; set; }
        public int RGA { get; set; }
        public String NomeAnimal { get; set; }
        public int IdadeAnimal { get; set; }
        public String Especie { get; set; }
        public String Raca { get; set; }
        public String Descricao { get; set; }
        public Dono dono { get; set; }

        public Animal() { }

        public Animal(int rGA, string nomeAnimal, int idadeAnimal, string especie, string raca, string descricao, Dono dono)
        {
            RGA = rGA;
            NomeAnimal = nomeAnimal;
            IdadeAnimal = idadeAnimal;
            Especie = especie;
            Raca = raca;
            Descricao = descricao;
            this.dono = dono;
        }

        public void Insert()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FUNCIONARIO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CEP", SqlDbType.VarChar).Value = Descricao ?? SqlString.Null;
            cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = (object)Descricao ?? DBNull.Value;
            cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = RGA;
            cmd.Parameters.Add("@RUA", SqlDbType.VarChar).Value = NomeAnimal;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Funcionário registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
