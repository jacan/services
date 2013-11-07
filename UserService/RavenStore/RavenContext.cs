using JacksFramework.Repositories;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenStore
{
	public class RavenContext : IRepositoryContext, IDisposable
	{
		IDocumentStore _documentStore;

		public RavenContext(string connectionString)
		{
			_documentStore = new DocumentStore { Url = connectionString };
			_documentStore.Initialize();

		}

		public void Dispose()
		{
			_documentStore.Dispose();
		}

		public void Add(dynamic entity)
		{
			using (var session = _documentStore.OpenSession())
			{
				session.Store(entity);
			}
		}
	}
}
