using System;
using System.Collections.Generic;
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
    public partial class DoctorMain : System.Web.UI.Page
    {
        Request request = new Request();
        List<PersonasEditCreateModel> allpacientes;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString() == "False")
                Response.Redirect("/Default.aspx");
            if (Session["ismedico"].ToString() != "True")
                Response.Redirect("/Historial.aspx");
            lblbienvenida.Text = Session["usermedico"].ToString(  );

        }

        protected void btnMiHistorial_Click(object sender, ImageClickEventArgs e)
        {
            Session["username"] = Session["usermedico"];
            Session["id"] = Session["idmedico"];
            Session["nombre"] = Session["nombrem"];
            Session["apellido"] = Session["apellidom"];
            Session["sexo"] = Session["sexom"];
            Session["nacimiento"] = Session["nacimientom"];
            Session["tiposangre"] = Session["tiposangrem"];
            Response.Redirect("/Historial.aspx");
        }

        protected void btnPacientes_Click(object sender, ImageClickEventArgs e)
        {
            Session["username"] = Session["usermedico"];
            Session["id"] = Session["idmedico"];
            Response.Redirect("/Doctor/DoctorPacientes.aspx");
            //LoadData();
            //Button1.Visible = true;
            //listado_pacientes.Text = "Listado de pacientes";
        }
        //public void LoadData()
        //{
        //    var url = "/api/personas/GetPacientes?id=" + Session["id"];
        //    var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
        //    var urlencoded = HttpUtility.UrlEncode(urlencrypted);
        //    var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
        //    var result = request.Using(WebRequestMethods.Http.Get, path);

        //    var jss = new JavaScriptSerializer();
        //    try
        //    {
        //        allpacientes = jss.Deserialize<List<PersonasEditCreateModel>>(result);
        //        Session["allpacientes"] = allpacientes;
        //        RadioButtonList1.DataSource = allpacientes.Select(x => (x.Nombres +" "+ x.Apellidos +"  Cédula: "+ x.Cedula));
        //        RadioButtonList1.DataBind();

        //    }
        //    catch (Exception) { }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //var salida = new List<String>();
            //for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            //{
            //    if (RadioButtonList1.Items[i].Selected == true)
            //        salida.Add(RadioButtonList1.Items[i].Text);
            //}
            //allpacientes = (List<PersonasEditCreateModel>)Session["allpacientes"];
            //foreach (var VARIABLE in salida)
            //{
            //    //Label1.Text = Label1.Text + " " + VARIABLE;
            //    if (allpacientes != null)
            //    {
            //        var id1 = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.idPersona));
            //        string id = "";
            //        if (id1.Count() > 0)
            //        {
            //            id = id1.First().ToString();
            //        }
            //        Session["id"] = id;
            //        string nombre1 = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.Nombres)).First();
            //        Session["nombre"] = nombre1;
            //        string apellido1 = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.Apellidos)).First();
            //        Session["apellido"] = apellido1;
            //        string nacimiento = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.FechaDeNacimiento)).First().ToShortDateString();
            //        Session["nacimiento"] = nacimiento;
            //        string sexo = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.Sexo)).First();
            //        Session["sexo"] = sexo;
            //        string tiposangre = (allpacientes.Where(c => (c.Nombres + " " + c.Apellidos + "  Cédula: " + c.Cedula) == VARIABLE).Select(c => c.TipoDeSangre)).First();
            //        Session["tiposangre"] = tiposangre;

                   
                }

               

            }
        }

