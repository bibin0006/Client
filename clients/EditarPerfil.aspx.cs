using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
        PersonasEditCreateModel persona;

        public string medico111 = "{\"IsMedico\":true,\"idPersona\":\"c06c7e2f-1204-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Alexander Ramon\",\"Apellidos\":\"Mendez Jimenez\",\"Sexo\":\"M\",\"Cedula\":\"5412422323\",\"FechaDeNacimiento\":\"\\/Date(658987200000)\\/\",\"Email\":\"alexander@gmail.com\",\"TelefonoResidencial\":\"8093214432\",\"TelefonoCelular\":\"8093125434\",\"idProvincia\":1,\"Direccion\":\"Calle Sal si puedes\",\"TipoDeSangre\":\"O+\",\"FechaDeDefuncion\":\"\\/Date(-62135582400000)\\/\",\"Username\":\"alexander\",\"Password\":null}";
        public string paciente111 = "{\"IsMedico\":false,\"idPersona\":\"c06c7e2f-1204-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Juan Fro\",\"Apellidos\":\"Mate Dipote\",\"Sexo\":\"M\",\"Cedula\":\"5412422323\",\"FechaDeNacimiento\":\"\\/Date(658987200000)\\/\",\"Email\":\"juan@gmail.com\",\"TelefonoResidencial\":\"8095554432\",\"TelefonoCelular\":\"8093125487\",\"idProvincia\":1,\"Direccion\":\"calle Principal\",\"TipoDeSangre\":\"O-\",\"FechaDeDefuncion\":\"\\/Date(-62135582400000)\\/\",\"Username\":\"juan\",\"Password\":null}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth"].ToString() == "False")
                Response.Redirect("/Default.aspx");
            LoadData();

        }

        public void LoadData()
        {
            //var url = "/api/personas/GetPersona?Username=" + Session["username"].ToString();
            //var urlencrypted = new SecureEncrypt().Encrypt(url, "password");
            //var path = "http://" + request.ipadd() + ":4001/api/user?url=" + urlencrypted;
            //var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            persona = jss.Deserialize<PersonasEditCreateModel>(medico111);
            if (Session["username"].ToString() == "juan")
                persona = jss.Deserialize<PersonasEditCreateModel>(paciente111);

            tel_edit.Text = persona.TelefonoResidencial;
            cel_edit.Text = persona.TelefonoCelular;
            dir_edit.Text = persona.Direccion;
            email_edit.Text = persona.Email;

            //var json = JObject.Parse(medico111);
            //tel_edit.Text = json[Personas.TelefonoResidencial.value].ToString();
            //cel_edit.Text = json[Personas.TelefonoCelular.value].ToString();
            //dir_edit.Text = json[Personas.Direccion.value].ToString();
            //email_edit.Text = json[Personas.Email.value].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var url = "/api/personas/" + persona.idPersona
                        + "?Email=" + persona.Email
                        + "&TelefonoResidencial=" + persona.TelefonoResidencial
                        + "&TelefonoCelular=" + persona.TelefonoCelular
                        + "&Direccion=" + persona.Direccion;
            var urlencrypted = new SecureEncrypt().Encrypt(url, "password");
            var path = "http://" + request.ipadd() + ":4001/api/user?url=" + urlencrypted;
            var result = request.Using(WebRequestMethods.Http.Put, path);
        }
    }
}