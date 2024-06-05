using System.Text.Json.Serialization;

namespace Relacionamentos.Models
{
	public class EnderecoModel
	{
		public int Id { get; set; }
		public string Rua { get; set; }
		public int Numero { get; set; }
		public int CasaId { get; set; }
		[JsonIgnore]
		public CasaModel Casa { get; set; }

	}
}
