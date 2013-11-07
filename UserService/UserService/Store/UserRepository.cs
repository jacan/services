using System;
using JacksFramework.Repositories;

namespace UserService.Store
{
	public interface IUserRepository
	{
		Guid CreateUser(string userName, string emailAddress);
	}

	public class UserRepository : IUserRepository
	{
		protected IRepositoryContext _context;

		public UserRepository(IRepositoryContext context)
		{
			_context = context;
		}

		public Guid CreateUser(string username, string email)
		{
			_context.Add(new
				{ 
					UserName = username, 
					EMail = email 
				});

			//TEST : CHANGE!
			return Guid.NewGuid();
		}
	}
}
