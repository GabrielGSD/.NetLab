namespace Relacionamentos.Dtos
{
	public class CasaCriacaoDto
	{
		public string Descricao { get; set; }
		public EnderecoCriacaoDto Endereco { get; set; }
		public List<QuartoCriacaoDto> Quartos { get; set; }
		public List<MoradorCriacaoDto> Moradores { get; set; }
	}
}
