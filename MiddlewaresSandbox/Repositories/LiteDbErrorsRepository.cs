using LiteDB;
using MiddlewaresSandbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Repositories
{
    public class LiteDbErrorsRepository : IErrorsRepository
    {
        private readonly LiteCollection<Error> ErrorsCollection;

        public LiteDbErrorsRepository(LiteDbContext liteDbContext)
        {
            ErrorsCollection = liteDbContext.Context.GetCollection<Error>("errors");
        }

        public void AddError(Error error)
        {
            ErrorsCollection.Insert(Guid.NewGuid().ToString(), error);
        }

        public IEnumerable<Error> GetErrors()
        {
            return ErrorsCollection.FindAll();
        }
    }
}
