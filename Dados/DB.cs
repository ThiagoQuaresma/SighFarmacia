using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace Dados
{
    public static class BD
    {
        static String strConexao = @"Data Source=E:\C#\FormLoginEstoque\AppTesteConexao.sdf;Password=123456;Persist Security Info=True";
        static SqlCeConnection conexao;

        public static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = strConexao;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection();
                    conexao.ConnectionString = strConexao;
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SqlCeDataReader ExecutarSelect(string _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarIDU(string _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }
    }
}
