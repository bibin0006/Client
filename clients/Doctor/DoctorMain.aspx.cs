using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clients.Doctor
{
    public partial class DoctorMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString()=="False")
                Response.Redirect("/Default.aspx");
            if (Session["ismedico"].ToString()!="True")
                Response.Redirect("/Historial.aspx");
        }

        protected void btnMiHistorial_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/Historial.aspx");
        }

        protected void btnPacientes_Click(object sender, ImageClickEventArgs e)
        {

        }



    }
}