using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using clients.Enumerable;
using clients.views;
using mvc4.Account;

namespace clients
{
    public partial class DeleteMedico1 : System.Web.UI.Page
    {
        Request request = new Request();
        List<PersonasEditCreateModel> allmedicos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString() == "False")
                Response.Redirect("/Default.aspx");
            if(!IsPostBack)
            LoadData();
        }

        public void LoadData()
        {
            var url = "/api/personas/GetMedicos?id=" + Session["id"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try
            {
                allmedicos = jss.Deserialize<List<PersonasEditCreateModel>>(result);
                Session["allmedicos"] = allmedicos;
                CheckBoxList1.DataSource = allmedicos.Select(x => (x.Nombres + " "+x.Apellidos));
                CheckBoxList1.DataBind();

            }
            catch (Exception) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var salida = new List<String>();
            for( int i = 0; i < CheckBoxList1.Items.Count; i++ ) {
                if(CheckBoxList1.Items[i].Selected == true)
                salida.Add(CheckBoxList1.Items[i].Text);
            }
            allmedicos = ( List<PersonasEditCreateModel> ) Session["allmedicos"];
            foreach( var VARIABLE in salida ) {
                //Label1.Text = Label1.Text + " " + VARIABLE;
                if( allmedicos != null ) {
                    var name1 =  ( allmedicos.Where( c => (c.Nombres+" "+c.Apellidos) == VARIABLE ).Select( c => c.idPersona ) );
                    string name="";
                    if(name1.Count() >0 )
                    {
                        name = name1.First().ToString();
                    }
                    var url = "/api/personas/DeleteMedico?id=" + Session["id"] + "&idMedico=" + name;
                    var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString()); 
                    var urlencoded = HttpUtility.UrlEncode(urlencrypted);
                    var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
                    var result = request.Using(WebRequestMethods.Http.Put, path);
                }
            }  
            Response.Redirect("/Historial.aspx");
        }
    }
}