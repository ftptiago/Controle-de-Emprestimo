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
    public partial class relatorio : Form
    {
        MySqlConnection connect;        
        MySqlDataAdapter dapter;
        string strSQL;

        

        public relatorio()
        {
            InitializeComponent();
        }

       
        private void relatorio_Load(object sender, EventArgs e)
        {
            carregarResult();
            
        }

        public void carregarResult()
        {
            try
            {
                strSQL = "SELECT * FROM emprestimo ORDER BY id DESC";
               
                   // strSQL = "SELECT * FROM emprestimo WHERE `usuario` = @SEARCH%  OR `conferente` = @SEARCH% ";
               
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                 //ORDER BY id DESC

                dapter = new MySqlDataAdapter(strSQL, connect);
                var dt = new DataSet();
               

                dapter.Fill(dt);
                dataGV.DataSource = dt.Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Clone();
                connect = null;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text is null)
            {
                carregarResult(); 
            }
            else
            {
                TextSearch();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextSearch()
        {
            try
            {
               
                connect = new MySqlConnection(@"server=10.8.0.14;user id=server;password=@Crcpuc1234;database=emprestimos;");

                strSQL = "SELECT * FROM emprestimo WHERE `usuario` = '" + search.Text + "' OR `conferente` = '" + search.Text + "' ORDER BY id DESC";
                //ORDER BY id DESC

                dapter = new MySqlDataAdapter(strSQL, connect);
                var dt = new DataSet();                

                dapter.Fill(dt);
                dataGV.DataSource = dt.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Clone();
                connect = null;                
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            carregarResult();
        }
    }
}
