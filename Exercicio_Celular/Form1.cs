using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Celular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        celular cel = new celular();
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                cel.setId(txt_id.Text);
                cel.setModelo(txt_modelo.Text);
                cel.setMarca(txt_marca.Text);
                cel.setTelefone(txt_telefone.Text);
                cel.inserir();

            }

            catch
            {
                MessageBox.Show("Erro na conexão com o Banco de Dados");
            }

            finally
            {
                MessageBox.Show("Informações enviadas com sucesso");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cel.Consultar();
            // DatagridView componente
            // Data Source ligação do banco com datagrid
            // Consultar metodo criado na classe empregado
            dataGridView1.Columns["id"].HeaderText = "Id";
            dataGridView1.Columns["modelo"].HeaderText = "Modelo";
            dataGridView1.Columns["marca"].HeaderText = "Marca";
            dataGridView1.Columns["telefone"].HeaderText = "telefone";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                cel.setId(txt_id.Text);
                cel.excluir();
            }

            catch
            {
                MessageBox.Show("Erro na conexão com o Banco de Dados");
            }

            finally
            {
                MessageBox.Show("Informações enviadas com sucesso");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_modelo.Text = "";
            txt_marca.Text = "";
            txt_telefone.Text = "";
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cel.setId(txt_id.Text);
                cel.setMarca(txt_marca.Text);
                cel.setModelo(txt_modelo.Text);
                cel.setTelefone(txt_telefone.Text);
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }
    }
}
