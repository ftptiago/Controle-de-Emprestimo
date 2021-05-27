using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Emprestimos
{
    
    public partial class testDialog : Form
    {

        public testDialog()
        {
            InitializeComponent();
        }

        // specifically typecasting the TYPE of form being passed in, 
        // not just a generic form.  We need to see the exposed elements
        Emprestimo CalledFrom, CalledFrom2;
        // Ensure to do the : this() to make sure default behavior
        // to initialize the controls on the form are created too.
        public testDialog(Emprestimo viaParameter) : this()
        {
            CalledFrom = viaParameter;
            CalledFrom2 = viaParameter;

        }

        private void TestDialog_Load(object sender, EventArgs e)
        {

        }
        
        private void DialogResult_Click(object sender, EventArgs e)
        {
            
            CalledFrom.ValuesByProperty = txtOnForm3.Text;
            CalledFrom2.ValuesByProperty2 = txtOnForm4.Text;

            string GettingBack = CalledFrom.ValuesByProperty;
            string GettingBack2 = CalledFrom2.ValuesByProperty2;
            this.Close();
            CalledFrom.EmprestimoItem(CalledFrom.ValuesByProperty, CalledFrom2.ValuesByProperty2);
            
        }

        private void txtOnForm3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
