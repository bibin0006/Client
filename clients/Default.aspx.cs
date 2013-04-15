using System;
using System.Net;
using System.Web.Script.Serialization;
using clients.Enumerable;
using clients.views;
using mvc4.Account;
using System.Web;

namespace clients
{
    public partial class Home : System.Web.UI.Page
    {
        Request request = new Request();
        //public string medico111 = "{\"IsMedico\":true,\"idPersona\":\"c06c7e2f-1204-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Alexander Ramon\",\"Apellidos\":\"Mendez Jimenez\",\"Sexo\":\"M\",\"Cedula\":\"5412422323\",\"FechaDeNacimiento\":\"\\/Date(658987200000)\\/\",\"Email\":\"alexander@gmail.com\",\"TelefonoResidencial\":\"8093214432\",\"TelefonoCelular\":\"8093125434\",\"idProvincia\":1,\"Direccion\":\"Calle Sal si puedes\",\"TipoDeSangre\":\"O+\",\"FechaDeDefuncion\":\"\\/Date(-62135582400000)\\/\",\"Username\":\"alexander\",\"Password\":null}";
        //public string paciente111 = "{\"IsMedico\":false,\"idPersona\":\"c06c7e2f-1204-4257-a0dc-c8e4f175ae71\",\"Nombres\":\"Juan Fro\",\"Apellidos\":\"Mate Dipote\",\"Sexo\":\"M\",\"Cedula\":\"5412422323\",\"FechaDeNacimiento\":\"\\/Date(658987200000)\\/\",\"Email\":\"juan@gmail.com\",\"TelefonoResidencial\":\"8095554432\",\"TelefonoCelular\":\"8093125487\",\"idProvincia\":1,\"Direccion\":\"calle Principal\",\"TipoDeSangre\":\"O-\",\"FechaDeDefuncion\":\"\\/Date(-62135582400000)\\/\",\"Username\":\"juan\",\"Password\":null}";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["ismedico"] = "false";
            Session["auth"] = "False";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Modificar encryp
            Session["hash"] = CriptoUtil.HashLogin(txtuser.Text,txtpass.Text);
            
            var url = "/api/personas/GetPersona?Username=" + txtuser.Text;
            var urlencrypted = new SecureEncrypt().Encrypt(url, Session["hash"].ToString());
            var urlencoded = HttpUtility.UrlEncode(urlencrypted);
            var path = "http://" + request.ipadd() + ":4001/api/user?id=" + txtuser.Text + "&url=" + urlencoded;
            var result = request.Using(WebRequestMethods.Http.Get, path);

            var jss = new JavaScriptSerializer();
            try{
                var persona = jss.Deserialize<PersonasEditCreateModel>(result);
                Session["id"] = persona.idPersona;
                Session["idmedico"] = persona.idPersona;
                Session["username"] = persona.Username;
                Session["usermedico"] = persona.Username;
                Session["ismedico"] = persona.IsMedico;
                Session["auth"] = "True";
                if (Session["ismedico"].ToString() == "True") {
                    Session["nombrem"] = persona.Nombres;
                    Session["apellidom"] = persona.Apellidos;
                    Session["sexom"] = persona.Sexo;
                    Session["nacimientom"] = persona.FechaDeNacimiento.ToShortDateString(  );
                    Session["tiposangrem"] = persona.TipoDeSangre;
                }  {
                    {
                        Session["nombre"] = persona.Nombres;
                        Session["apellido"] = persona.Apellidos;
                        Session["sexo"] = persona.Sexo;
                        Session["nacimiento"] = persona.FechaDeNacimiento.ToShortDateString();
                        Session["tiposangre"] = persona.TipoDeSangre;
                    }
                }
                Response.Redirect(Session["ismedico"].ToString() == "True" ? "Doctor/DoctorMain.aspx" : "/Historial.aspx");
            }
            catch (Exception)
            {

                Label1.Text = "Username o password no válido";
                
            }
            
            //////var o = JObject.Parse(result);
            //////Label1.Text = (string)o["IsMedico"];
            
        }
    }
}