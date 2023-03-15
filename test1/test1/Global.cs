using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace test1
{
    internal class Global
    {
        public static MySqlConnection Conexao;//conexao
        public static MySqlCommand Comando;//comandos
        public static MySqlDataAdapter Adaptador;//inserir dados numa tabela
        public static DataTable datTabela;//ligar a db em controlos com prop de DataSource


        public static string Add(string Name, string Pass)
        {
            try{
                Conexao = new MySqlConnection("server=localhost;database=teste1;uid=root;pwd=root");
                Conexao.Open();

            }catch{return "Erro ao abrir o banco de dados"; }
            
            try{
                Comando = new MySqlCommand("INSERT INTO user (Nome, Pass) VALUES ('" + Name + "' ,'" + Pass + "' );", Conexao);
                Comando.ExecuteNonQuery();

            }
            catch { return "Erro ao adicionar dados"; }

            try{ Conexao.Close();

            }catch{ return "Erro ao fechar o banco de dados"; }

            return "sucesso";
        }
        public static string Update(string Name, string Pass, int n)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;database=teste1;uid=root;pwd=root");
                Conexao.Open();

            }
            catch { return "Erro ao abrir o banco de dados"; }

            try
            {
                Comando = new MySqlCommand("update user set Nome = '"+ Name +"', Pass='"+ Pass +"' where ID = "+n+";", Conexao);
                Comando.ExecuteNonQuery();

            }
            catch { return "Erro ao adicionar dados"; }

            try
            {
                Conexao.Close();

            }
            catch { return "Erro ao fechar o banco de dados"; }

            return "sucesso";
        }
        public static string Remove(int n)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;database=teste1;uid=root;pwd=root");
                Conexao.Open();

            }
            catch { return "Erro ao abrir o banco de dados"; }

            try
            {
                Comando = new MySqlCommand("DELETE FROM user WHERE ID = "+n+";", Conexao);
                Comando.ExecuteNonQuery();

            }
            catch { return "Erro ao adicionar dados"; }

            try
            {
                Conexao.Close();

            }
            catch { return "Erro ao fechar o banco de dados"; }

            return "sucesso";
        }


        public static DataTable Data()
        {

            Conexao = new MySqlConnection("server=localhost;database=teste1;uid=root;pwd=root");
            Conexao.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM User;", Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);


            return dt;
        }

    }
}
