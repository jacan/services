using JacksFramework.Repositories;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Store;

namespace RavenStore
{
    public class RavenContext : IRepositoryContext, IDisposable
    {
        IDocumentStore _documentStore;

        public RavenContext(string connectionString="http://www.localhost/:8080")
        {
            _documentStore = new DocumentStore();            
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
