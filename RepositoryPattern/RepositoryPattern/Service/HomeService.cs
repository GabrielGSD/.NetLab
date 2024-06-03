namespace RepositoryPattern.Service
{
	public class HomeService : IHomeInterface
	{
		public string retornaString()
		{
			return "Olá acessou o serviço!";
		}
	}
}
