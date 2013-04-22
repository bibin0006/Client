using System;

namespace mvc4.Models.EntitiesView
{
	public class DescripcionViewModel{
		public string Descripcion { get; set; }
	}

	public class TraumaticosViewModel{
		public DateTime Fecha { get; set; }
		public string Descripción { get; set; }
	}

	public class TransfusionalesViewModel{
		public DateTime Fecha { get; set; }
		public string Notas { get; set; }
		public string OrganosDescripcion { get; set; }
		
	}
}