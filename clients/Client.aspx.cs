using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using clients.Enumerable;
using mvc4.Account;
using mvc4.Models.EntitiesView;


namespace clients
{
    public partial class Client : System.Web.UI.Page
    {
        string id = "C06C7E2F-1805-4257-A0DC-C8E4F175AE71";
        Request request = new Request();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData(  );
        }

        public void LoadData()
        {
            
            var url = "/api/personas/GetHistorial?id=" + id;
            var urlencrypted = new SecureEncrypt().Encrypt(url, "password");
            var path = "http://" + request.ipadd() + ":4001/api/user?url=" + urlencrypted;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            var historial_medico = jss.Deserialize<HistorialMedicoViewModel>(result);
            var enfermedades = historial_medico.AntecedentesEnfermedades.Select( VARIABLE => VARIABLE.Descripcion ).ToList( );
            ListBox1.DataSource = enfermedades;
            ListBox1.DataBind(  );
           // historial_medico.AntecedentesEnfermedades.ForEach( enfermedad => Label1.Text += " " + enfermedad.Descripcion );
            Label1.Text = result;
        }
    }
}