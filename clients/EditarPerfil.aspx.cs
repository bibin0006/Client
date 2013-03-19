using System;
using System.Web;
using clients.views;
using System.Web.Script.Serialization;
using clients.Enumerable;
using mvc4.Account;
using System.Net;

namespace clients
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Request request = new Request();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString() == "False")
                Response.Redirect("/Default.aspx");
            if(!IsPostBack)
            LoadData();

        }

        public void LoadData()
        {
            var url = "/api/personas/GetPersona?Username=" + Session["username"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try
            {
                var persona = jss.Deserialize<PersonasEditCreateModel>(result);
                tel_edit.Text = persona.TelefonoResidencial;
                cel_edit.Text = persona.TelefonoCelular;
                dir_edit.Text = persona.Direccion;
                email_edit.Text = persona.Email;
            }
            catch( Exception ) {}
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var url = "/api/personas/" + Session["id"]
                      + "?Email=" + email_edit.Text
                      + "&TelefonoResidencial=" + tel_edit.Text
                      + "&TelefonoCelular=" + cel_edit.Text
                      + "&Direccion=" + dir_edit.Text;
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Put, path);
        }
    }
}