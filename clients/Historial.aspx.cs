using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
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
            var enfermedades = historial_medico.AntecedentesEnfermedades.Select(VARIABLE => VARIABLE.Fecha.ToShortDateString(  ) + " " + VARIABLE.Descripcion).ToList();
            historial_medico.AntecedentesEnfermedades.ForEach(enfermedad =>
            {
                var AccordionPane1 = new AccordionPane { ID = Guid.NewGuid().ToString() };
                AccordionPane1.HeaderContainer.Controls.Add(new LiteralControl(enfermedad.Fecha.ToShortDateString() + " ----  " + enfermedad.Descripcion));
                AccordionPane1.ContentContainer.Controls.Add(new LiteralControl(enfermedad.Comentarios));
                Accordion1.Panes.Add(AccordionPane1);
            });
            //ListBox1.DataSource = enfermedades;
            //ListBox1.DataBind();

            var alergias = historial_medico.AntecedentesAlergico.Select(VARIABLE => VARIABLE.Fecha.ToShortDateString() + " ----  " + VARIABLE.ElemmentoAlergico).ToList();
            historial_medico.AntecedentesAlergico.ForEach(alergia =>
            {
                var AccordionPane1 = new AccordionPane { ID = Guid.NewGuid().ToString() };
                AccordionPane1.HeaderContainer.Controls.Add(new LiteralControl(alergia.Fecha.ToShortDateString() + " ----  " + alergia.ElemmentoAlergico));
                AccordionPane1.ContentContainer.Controls.Add(new LiteralControl(alergia.Comentarios));
                Accordion2.Panes.Add(AccordionPane1);
            });

            var procedimientos = historial_medico.AntecedentesProcedimientos.Select(VARIABLE => VARIABLE.Fecha.ToShortDateString() + " ----  " + VARIABLE.Descripcion).ToList();
            historial_medico.AntecedentesProcedimientos.ForEach(procedimiento =>
            {
                var AccordionPane1 = new AccordionPane { ID = Guid.NewGuid().ToString() };
                AccordionPane1.HeaderContainer.Controls.Add(new LiteralControl(procedimiento.Fecha.ToShortDateString() + " ----  " + procedimiento.Descripcion));
                AccordionPane1.ContentContainer.Controls.Add(new LiteralControl(procedimiento.Comentarios));
                Accordion3.Panes.Add(AccordionPane1);
            });

            var toxicos = historial_medico.AntecedentesToxicos.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            historial_medico.AntecedentesToxicos.ForEach(toxico =>
            {
                var AccordionPane1 = new AccordionPane { ID = Guid.NewGuid().ToString() };
                AccordionPane1.HeaderContainer.Controls.Add(new LiteralControl(toxico.Descripcion));
                //AccordionPane1.ContentContainer.Controls.Add(new LiteralControl(toxico.Comentarios));
                Accordion4.Panes.Add(AccordionPane1);
            });

            var enfermedades_hereditarias = historial_medico.EnfermedadesHereditarias.Select(VARIABLE => VARIABLE.Descripcion).ToList();
            historial_medico.EnfermedadesHereditarias.ForEach(hereditaria =>
            {
                var AccordionPane1 = new AccordionPane { ID = Guid.NewGuid().ToString() };
                AccordionPane1.HeaderContainer.Controls.Add(new LiteralControl(hereditaria.Descripcion));
                //AccordionPane1.ContentContainer.Controls.Add(new LiteralControl(toxico.Comentarios));
                Accordion5.Panes.Add(AccordionPane1);
            });




          

           

            

                //AccordionPane2.HeaderContainer.Controls.Add(new LiteralControl("Using Markup"));
                //AccordionPane2.ContentContainer.Controls.Add(new
                //LiteralControl("Adding panes using markup is really simple."));

                //Accordion1.Panes.Add(AccordionPane2);
                

            //historial_medico.AntecedentesEnfermedades.ForEach(enfermedad => Label1.Text += \" \" + enfermedad.Descripcion);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

       
    }
}