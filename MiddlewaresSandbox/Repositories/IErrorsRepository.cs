using MiddlewaresSandbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Repositories
{
    public interface IErrorsRepository
    {
        IEnumerable<Error> GetErrors();

        void AddError(Error error);
    }
}
