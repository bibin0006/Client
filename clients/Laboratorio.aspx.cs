using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using clients.Enumerable;
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
            if(!IsPostBack)
            LoadData();
            Label1.Text = Session["nombre"].ToString() +" "+ Session["apellido"].ToString();
        }

        public void LoadData()
        {
            var url = "/api/personas/GetAnalisisPendientes?id=" + Session["id"];
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["id"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try{
                allexams = jss.Deserialize<List<AnalisisConsultaViewModel>>(result);
                if (allexams.Count > 0){
                    Session["allexams"] = allexams;
                    RadioButtonList1.DataSource = allexams.Select(x => x.AnalisisDescripcion);
                    RadioButtonList1.SelectedIndex = 0;
                    RadioButtonList1.DataBind();
                }
            }catch( Exception ) { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            allexams = (List<AnalisisConsultaViewModel>)Session["allexams"];
            var resultado = RadioButtonList1.SelectedValue;
            if( allexams == null ) return;
            var analisis_consultado = allexams.Find(x => x.AnalisisDescripcion == resultado);

            var ext = System.IO.Path.GetExtension(FileUpload1.FileName);

            var local_path = Server.MapPath("~\\Files\\");
            var file_path = local_path + FileUpload1.PostedFile.FileName;
            FileUpload1.SaveAs( file_path );
            //var file_path = Server.MapPath(FileUpload1.FileName);
            var file_name = Session["id"] + "/" + resultado + " " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ext;
            MedicsS3.S3Util.UploadFile(file_path, file_name);

            
            var url = "/api/Instituciones/PutResultadoAnalisis?"
                + "idAnalisisConsulta=" + analisis_consultado.idAnalisisConsulta
                + "&idInstitucion=" + Session["idi"]
                + "&urlPath=" + file_name;
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + Session["username"] + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Post, path);

            Response.Redirect("/UserLogin.aspx");
        }
       
        
    }
}