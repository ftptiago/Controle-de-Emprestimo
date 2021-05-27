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
    public partial class Emprestimo : Form
    {
        MySqlConnection connect;
        MySqlCommand comm;
        MySqlDataAdapter dapter;
       string strSQL;

        

        public Emprestimo()
        {
            InitializeComponent();
            

        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void adicionarItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            carregarList();
            carregarListEmprestimo();
        }

        public void carregarList()
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "SELECT * FROM item WHERE status = 0 ";
                dapter = new MySqlDataAdapter(strSQL, connect);
                DataTable dt = new DataTable();

                dapter.Fill(dt);
                listBoxRef.Items.Clear();


                foreach (DataRow dr in dt.Rows)
                {
                    string Texto = listBoxRef.GetItemText(listBoxRef.Items.Add(dr["id"] + " " + dr["descricao"].ToString()));

                }


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

        public void carregarListEmprestimo()
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "SELECT * FROM emprestimo as E, item as I WHERE status = 1 AND E.item_id = I.id AND E.devolucao is null ";
                dapter = new MySqlDataAdapter(strSQL, connect);
                DataTable dt = new DataTable();

                dapter.Fill(dt);
                listBoxEmp.Items.Clear();


                foreach (DataRow dr in dt.Rows)
                {
                    listBoxEmp.Items.Add(dr["id"] + " " + dr["descricao"] + " " + dr["observacao"] + " " + dr["retirada"].ToString());
                }
                

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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBoxRef.SelectedIndex; //pegando o index do item selecionado         
            
            if (i >= 0)
            {
                testDialog txt = new testDialog(this);
                txt.Show();

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    string idUser = textBox1.Text;
                    string obs = textBox2.Text;
                    EmprestimoItem(idUser, obs);
                }
            }
            
        }

        public void EmprestimoItem(string idUser, string obs)
        {
            int i = listBoxRef.SelectedIndex; //pegando o index do item selecionado           


            if (i >= 0)
            {

                string valor = listBoxRef.Items[i].ToString(); //posicionando o outro listbox
                string[] valores = valor.Split(' ');

                    try
                    {
                        connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                        strSQL = "UPDATE item SET status = @status WHERE id = @ID";
                        comm = new MySqlCommand(strSQL, connect);
                        comm.Parameters.AddWithValue("@ID", valores[0]);
                        comm.Parameters.AddWithValue("@status", 1);

                        connect.Open();
                        comm.ExecuteNonQuery();


                        string Usuario = idUser;
                        string Valor = valores[0];
                        textBox1.Text = null;
                        textBox2.Text = null;
                        insertEmprestimo(Valor, obs, Usuario);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                

            }
        }

        
        public void insertEmprestimo(string txtid, string txtObservacao, string txtUsuario)
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "INSERT INTO `emprestimo`(`retirada`, `usuario`, `observacao`, `item_id`) VALUES (CURRENT_TIMESTAMP, @usuario, @observacao, @item_id)";
                comm = new MySqlCommand(strSQL, connect);

                comm.Parameters.AddWithValue("@item_id", txtid);
                comm.Parameters.AddWithValue("@usuario", txtUsuario);
                comm.Parameters.AddWithValue("@observacao", txtObservacao);

                connect.Open();
                comm.ExecuteNonQuery();
                carregarList();
                carregarListEmprestimo();
                MessageBox.Show("Item Emprestado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        private void listBoxRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBoxEmp.SelectedIndex; //pegando o index do item selecionado         

            if (i >= 0)
            {

                testDialog2 txt2 = new testDialog2(this);
                txt2.Show();

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    string idUser = textBox1.Text;
                    string obs = textBox2.Text;                    
                    devolucaoItem(idUser, obs);
                }

            }
        }

        public void devolucaoItem(string idUser, string observacao)
        {
            int i = listBoxEmp.SelectedIndex; //pegando o index do item selecionado           


            if (i >= 0)
            {

                try
                {
                    string valor = listBoxEmp.Items[i].ToString(); //posicionando o outro listbox
                    string[] valores = valor.Split(' ');

                    string item_id = valores[0];
                    string val = returnIdItem(item_id);

                    connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                    strSQL = "UPDATE item SET status = @status WHERE id = @ID";
                    comm = new MySqlCommand(strSQL, connect);
                    comm.Parameters.AddWithValue("@ID", val);
                    comm.Parameters.AddWithValue("@status", 0);

                    connect.Open();
                    comm.ExecuteNonQuery();

                    string Usuario = idUser;
                    string obs =  observacao;
                    string Valor = valores[0];
                    textBox1.Text = null;
                    textBox2.Text = null;
                    updateEmprestimo(Valor, obs, Usuario);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        public string returnIdItem(string txtId)
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");
                connect.Open();                
                strSQL = "SELECT item_id FROM emprestimo WHERE id = @ID";
                comm = new MySqlCommand(strSQL, connect);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@ID", txtId);

                comm.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comm.ExecuteReader();
                dr.Read();
                
                return dr.GetString(0);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void updateEmprestimo(string txtid, string txtObs, string txtUsuario)
        {
            try
            {
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "UPDATE `emprestimo` SET `devolucao`= CURRENT_TIMESTAMP, `obsEntrega` = @obsEntrega, `conferente`= @conferente WHERE `id`= @ID";
                comm = new MySqlCommand(strSQL, connect);

                comm.Parameters.AddWithValue("@ID", txtid);
                comm.Parameters.AddWithValue("@obsEntrega", txtObs);
                comm.Parameters.AddWithValue("@conferente", txtUsuario);

                connect.Open();
                comm.ExecuteNonQuery();

                carregarList();
                carregarListEmprestimo();

                MessageBox.Show("Item Devolvido!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ValuesByProperty
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        public string ValuesByProperty2
        {
            get { return this.textBox2.Text; }
            set { this.textBox2.Text = value; }
        }

        public void SetViaMethod(string newValue)
        { this.textBox1.Text = newValue; }

        public string GetViaMethod()
        { return this.textBox1.Text; }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio Result = new relatorio();
            Result.Show();
        }
    }
}
