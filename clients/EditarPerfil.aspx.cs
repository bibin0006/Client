using System;
using clients.views;
using System.Web.Script.Serialization;
using clients.Enumerable;
using mvc4.Account;
using System.Net;

namespace clients
{
    public partial class EditarPerfil : System.Web.UI.Page
    {
        Request request = new Request();
        PersonasEditCreateModel persona;

        public string medico111 = "{\"IsMedico\":true,\"idPersona\":\"c06c7e2f-1204-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Alexander Ramon\",\"Apellidos\":\"Mendez Jimenez\",\"Sexo\":\"M\",\"Cedula\":\"5412422323\",\"FechaDeNacimiento\":\"\\/Date(658987200000)\\/\",\"Email\":\"alexander@gmail.com\",\"TelefonoResidencial\":\"8093214432\",\"TelefonoCelular\":\"8093125434\",\"idProvincia\":1,\"Direccion\":\"Calle Sal si puedes\",\"TipoDeSangre\":\"O+\",\"FechaDeDefuncion\":\"\\/Date(-62135582400000)\\/\",\"Username\":\"alexander\",\"Password\":null}";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData() {

            var jss = new JavaScriptSerializer();
            persona = jss.Deserialize<PersonasEditCreateModel>(medico111);
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
            const string ipadd = "10.0.0.11";
            var url = "/api/personas/" + persona.idPersona
                        + "?Email=" + persona.Email
                        + "&TelefonoResidencial=" + persona.TelefonoResidencial
                        + "&TelefonoCelular=" + persona.TelefonoCelular
                        + "&Direccion=" + persona.Direccion;
            var urlencrypted = new SecureEncrypt().Encrypt(url, "password");
            var path = "http://" + ipadd + ":4001/api/user?url=" + urlencrypted;
            var result = request.Using(WebRequestMethods.Http.Put, path);
        }
    }
}