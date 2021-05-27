using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Emprestimos
{
    public partial class Form2 : Form
    {
        MySqlConnection connect;
        MySqlCommand comm;
        MySqlDataAdapter dapter;
        MySqlDataReader reader;
        string strSQL;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "INSERT INTO item (nome, tipo_item_id, descricao) VALUES (@nome, @tipo, @descricao)";
                comm = new MySqlCommand(strSQL, connect);
                comm.Parameters.AddWithValue("@nome", txtNome.Text);
                comm.Parameters.AddWithValue("@tipo", txtTipo.Text);
                comm.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                connect.Open();
                comm.ExecuteNonQuery();
                txtTipo.Text = null;
                txtNome.Text = null;
                txtDescricao.Text = null;

                
                MessageBox.Show("Item Cadastrado!");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Clone();
                connect = null;
                comm = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "UPDATE item SET nome = @nome, tipo_item_id= @tipo, descricao = @descricao WHERE id = @ID";
                comm = new MySqlCommand(strSQL, connect);
                comm.Parameters.AddWithValue("@ID", txtId.Text);
                comm.Parameters.AddWithValue("@nome", txtNome.Text);
                comm.Parameters.AddWithValue("@tipo", txtTipo.Text);
                comm.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                connect.Open();
                comm.ExecuteNonQuery();
                txtTipo.Text = null;
                txtNome.Text = null;
                txtDescricao.Text = null;


                MessageBox.Show("Item Cadastrado!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Clone();
                connect = null;
                comm = null;
            }
        }
    }
}
