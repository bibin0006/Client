using System;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using clients.Enumerable;
using clients.views;
using mvc4.Account;

namespace clients
{
    public partial class LabLogin : System.Web.UI.Page
    {
        Request request = new Request();
       
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Session["auth"] = "False";
            Label2.Text=Session["nombreinstitucion"].ToString(  );
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Modificar encryp
            Session["hash"] = CriptoUtil.HashLogin(txtuser.Text, txtpass.Text);
      
            var url = "/api/personas/GetPersona?Username=" + txtuser.Text;
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + txtuser.Text + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try
            {
                var persona = jss.Deserialize<PersonasEditCreateModel>(result);
                Session["id"] = persona.idPersona;
                Session["username"] = persona.Username;
                Session["auth"] = "True";
                Session["nombre"] = persona.Nombres;
                Session["apellido"] = persona.Apellidos;
                Response.Redirect("/Laboratorio.aspx");
                      
            }

            catch (Exception)
            {

                Label1.Text = "Username o password no válido";

            }

        }
    }
}