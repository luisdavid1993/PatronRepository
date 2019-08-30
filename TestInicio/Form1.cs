using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.Dto;

namespace TestInicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txbAlternateID.Text = "CRM12829787";
            this.txbContactID.Text = "28501";
            this.txbContactName.Text = "IMPORTADORA CALI S.A";
            this.txbDetailID.Text = "0";
            this.txbUserSite.Text = "1";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            CP_UsersLogTabTelefonia _usersLogTabTelefonia = new CP_UsersLogTabTelefonia();
            _usersLogTabTelefonia.vchUser = "ejt4940a";
            _usersLogTabTelefonia.vchAlternateId = this.txbAlternateID.Text;
            _usersLogTabTelefonia.vchContacId =Convert.ToInt32(this.txbContactID.Text);
            _usersLogTabTelefonia.vchContactName = this.txbContactName.Text;
            _usersLogTabTelefonia.vchDetailId = Convert.ToInt32(this.txbDetailID.Text);
            _usersLogTabTelefonia.vchUserSite = Convert.ToInt32(this.txbUserSite.Text);
            navegador _navegador = new navegador(_usersLogTabTelefonia);
            _navegador.Show();
        }
    }
}
