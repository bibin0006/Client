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
using mvc4.Models.EntitiesView;

namespace clients
{
    public partial class Laboratorio : System.Web.UI.Page
    {
        Request request = new Request();
        List<AnalisisConsultaViewModel> allexams;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
            Label1.Text = Session["nombre"].ToString(  );
        }

        public void LoadData()
        {
            var url = "/api/personas/GetAnalisisPendientes?id=" + Session["id"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["id"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try
            {
                allexams = jss.Deserialize<List<AnalisisConsultaViewModel>>(result);
                Session["allexams"] = allexams;
                RadioButtonList1.DataSource = allexams.Select(x => x.AnalisisDescripcion);
                RadioButtonList1.DataBind();

            }
            catch (Exception) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var salida = new List<String>();
            for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            {
                if (RadioButtonList1.Items[i].Selected == true)
                    salida.Add(RadioButtonList1.Items[i].Text);
            }
            allexams = ( List<AnalisisConsultaViewModel> ) Session["allexams"];
            foreach (var VARIABLE in salida)
            {
                //Label1.Text = Label1.Text + " " + VARIABLE;
                if (allexams != null)
                {
                    var id1 = (allexams.Where(c => c.AnalisisDescripcion == VARIABLE).Select(c => c.idAnalisis));
                    string id = "";
                    if (id1.Count() > 0)
                    {
                        id = id1.First().ToString();
                    }
                    Session["id"] = id;
                    Response.Redirect("/Historial.aspx");
                }
            }
        }
    }
}