using mvc4.Models.EntitiesEditCreate;

namespace clients.Enumerable
{
	public class Personas : Model
    {
        public Personas(string value):base(value){ }

        public static Personas Nombres = new Personas("Nombres");
        public static Personas Apellidos = new Personas("Apellidos");
        public static Personas Sexo = new Personas("Sexo");
        public static Personas Cedula = new Personas("Cedula");
        public static Personas FechaDeNacimiento = new Personas("FechaDeNacimiento");
        public static Personas Email = new Personas("Email");
        public static Personas TelefonoResidencial = new Personas("TelefonoResidencial");
        public static Personas TelefonoCelular = new Personas("TelefonoCelular");
        public static Personas idProvincia = new Personas("idProvincia");
        public static Personas Direccion = new Personas("Direccion");
        public static Personas TipoDeSangre = new Personas("TipoDeSangre");
        public static Personas FechaDeDefuncion = new Personas("FechaDeDefuncion");
        public static Personas Username = new Personas("Username");
        public static Personas Password = new Personas("Password");
        public static Personas IsMedico = new Personas("IsMedico");
        public static Personas idPersona = new Personas("idPersona");
    }
}