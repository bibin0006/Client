using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clients.Enumerable;
using System.Web.Script.Serialization;
using mvc4.Account;
using mvc4.Models.EntitiesView;

namespace clients
{
    public partial class Historial : System.Web.UI.Page
    {
        
        Request request = new Request();
       // public string medico112 = "{\"idPersona\":\"c06c7e2f-1805-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Alexander Ramon\",\"Apellidos\":\"Mendez Jimenez\",\"AntecedentesToxicos\":[{\"Descripcion\":\"toxico_5\"},{\"Descripcion\":\"toxico_1\"},{\"Descripcion\":\"toxico_3\"}],\"AntecedentesAlergico\":[{\"ElemmentoAlergico\":\"cosa_5\",\"TipoDeAlergia\":\"tipo_5\"}],\"AntecedentesProcedimientos\":[],\"AntecedentesEnfermedades\":[{\"Descripcion\":\"enfermedad_2\"},{\"Descripcion\":\"enfermedad_3\"},{\"Descripcion\":\"enfermedad_4\"}],\"EnfermedadesHereditarias\":[{\"Descripcion\":\"enfermedad_5\"},{\"Descripcion\":\"enfermedad_1\"}]}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString() == "False")
                Response.Redirect("/Default.aspx"); 
            
            LoadData();
        }

        public void LoadData()
        {

            var url = "/api/personas/GetHistorial?id=" + Session["id"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["idmedico"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            var historial_medico = jss.Deserialize<HistorialMedicoViewModel>(result);
            var enfermedades = historial_medico.AntecedentesEnfermedades.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            ListBox1.DataSource = enfermedades;
            ListBox1.DataBind();

            var alergias = historial_medico.AntecedentesAlergico.Select(VARIABLE => VARIABLE.ElemmentoAlergico).ToList();
            ListBox2.DataSource = alergias;
            ListBox2.DataBind();

            var procedimientos = historial_medico.AntecedentesProcedimientos.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            ListBox3.DataSource = procedimientos;
            ListBox3.DataBind();

            var toxicos = historial_medico.AntecedentesToxicos.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            ListBox4.DataSource = alergias;
            ListBox4.DataBind();

            var enfermedades_hereditarias = historial_medico.EnfermedadesHereditarias.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            ListBox5.DataSource = enfermedades_hereditarias;
            ListBox5.DataBind();

            //historial_medico.AntecedentesEnfermedades.ForEach(enfermedad => Label1.Text += \" \" + enfermedad.Descripcion);

        }
    }
}