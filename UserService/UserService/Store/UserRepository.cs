using JacksFramework.Repositories;

namespace UserService.Store
{
	public class UserRepository
	{
		protected IRepositoryContext _context;

		public UserRepository(IRepositoryContext context)
		{
			_context = context;
		}

		public void CreateUser(string username, string email)
		{
			_context.Add((email));
		}
	}
}
