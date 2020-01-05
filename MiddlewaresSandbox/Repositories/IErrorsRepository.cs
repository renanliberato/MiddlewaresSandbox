using MiddlewaresSandbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Repositories
{
    public interface IErrorsRepository
    {
        Task<IList<Error>> GetErrors();

        Task AddError(Error error);
    }
}
