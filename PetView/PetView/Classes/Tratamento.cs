using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Tratamento : ICadastro
    {
        public int CodTratamento { get; set; }
        public Medico medico { get; set; }
        public Animal animal { get; set; }
        public String Observacao { get; set; }
        public double Custo { get; set; }
        public String TipoTratamento { get; set; }
        public DateTime DataTratamento { get; set; }

        public static DataTable Select(String type, String value)
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("sp_select_tratamento", con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

                if ("Código".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@cod_tratamento", SqlDbType.Int).Value = Convert.ToInt32(value);
                }
                else if ("Nome do animal".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@nome_animal", SqlDbType.VarChar).Value = value;
                }
                else if ("Nome do médico".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@nome_medico", SqlDbType.VarChar).Value = value;
                }
                else if ("Nome do dono".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@nome_dono", SqlDbType.VarChar).Value = value;
                }
                else if ("Custo".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@custo_tratamento", SqlDbType.Money).Value = Convert.ToDouble(value);
                }
                else if ("Tipo".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@tipo_tratamento", SqlDbType.VarChar).Value = value;
                }
                else if ("Data".Equals(type))
                {
                    cmd.SelectCommand.Parameters.Add("@data_tratamento", SqlDbType.DateTime).Value = value;
                }
                DataTable dtbl = new DataTable();
                cmd.Fill(dtbl);
                return dtbl;
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
