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
    public partial class navegador : Form
    {
        private CP_UsersLogTabTelefonia _usersLogTabTelefonia;
        public navegador(CP_UsersLogTabTelefonia _usersLogTabTelefonia)
        {
            InitializeComponent();
            this._usersLogTabTelefonia = _usersLogTabTelefonia;
        }

        public string rutaWeb()
        {
            string ruta = "http://localhost:60398?vchUser=";
            ruta = ruta + _usersLogTabTelefonia.vchUser + "&vchAlternateId=";
            ruta = ruta + _usersLogTabTelefonia.vchAlternateId + "&vchContacId=";
            ruta = ruta + _usersLogTabTelefonia.vchContacId + "&vchContactName=";
            ruta = ruta + _usersLogTabTelefonia.vchContactName + "&vchDetailId=";
            ruta = ruta + _usersLogTabTelefonia.vchDetailId + "&vchUserSite=";
            ruta = ruta + _usersLogTabTelefonia.vchUserSite;
            return ruta;
        }

        private void navegador_Load(object sender, EventArgs e)
        {
            this.webBrowserTab.Url = new Uri(rutaWeb(), System.UriKind.Absolute);
        }
    }
}
