using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using clients.Enumerable;
using clients.views;
using mvc4.Account;

namespace clients.Doctor
{
    public partial class DoctorPacientes : System.Web.UI.Page
    {
        Request request = new Request();
        List<PersonasEditCreateModel> allpacientes;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var url = "/api/personas/GetPacientes?id=" + Session["id"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try
            {
                allpacientes = jss.Deserialize<List<PersonasEditCreateModel>>(result);
                Session["allpacientes"] = allpacientes;

                DataTable table = new DataTable();

                //Se establece el nombre y el tipo de dato de las columnas
                table.Columns.Add("Nombres", typeof(string));
                table.Columns.Add("Apellidos", typeof(string));
                table.Columns.Add("Sexo", typeof(string));
                table.Columns.Add("Cédula", typeof(string));

                int i = 0;
                foreach (var persona in allpacientes)
                {
                    table.Rows.Add(allpacientes[i].Nombres, allpacientes[i].Apellidos, allpacientes[i].Sexo, allpacientes[i++].Cedula);
                }
                GridView1.DataSource = table;
                GridView1.DataBind();

            }
            catch (Exception) { }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text + GridView1.Rows[e.NewSelectedIndex].Cells[2].Text + GridView1.Rows[e.NewSelectedIndex].Cells[4].Text;
            

            allpacientes = (List<PersonasEditCreateModel>)Session["allpacientes"];

            if (allpacientes != null)
            {
                var id1 = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.idPersona));
                string id = "";
                if (id1.Count() > 0)
                {
                    id = id1.First().ToString();
                }
                Session["id"] = id;
                string nombre1 = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.Nombres)).First();
                Session["nombre"] = nombre1;
                string apellido1 = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.Apellidos)).First();
                Session["apellido"] = apellido1;
                string nacimiento = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.FechaDeNacimiento)).First().ToShortDateString();
                Session["nacimiento"] = nacimiento;
                string sexo = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.Sexo)).First();
                Session["sexo"] = sexo;
                string tiposangre = (allpacientes.Where(c => (c.Nombres + c.Apellidos + c.Cedula) == text).Select(c => c.TipoDeSangre)).First();
                Session["tiposangre"] = tiposangre;

                Response.Redirect("/Historial.aspx");

            }
        }
    }
}