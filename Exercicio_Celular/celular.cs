using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Celular
{
    internal class celular : conexao
    {
        private string id;
        private string modelo;
        private string marca;
        private string telefone;

        public void setId(string id)
        {
            this.id = id;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getId()
        {
            return this.id;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void inserir()
        {
            string query = "insert into celular(id, modelo, marca, telefone)VALUES('" + getId() + "','" + getModelo() + "','" + getMarca() + "','" + getTelefone() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "select * from celular";

            // Execução da query "mSQL"
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();

            // Demonstração da tabela
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from celular where id = '" + getId() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void alterar()
        {
            string query = "Update celular set id = '" + getId() + "', marca = '" + getMarca() + "', modelo = '" + getModelo() + "' where telefone = '" + getTelefone() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}