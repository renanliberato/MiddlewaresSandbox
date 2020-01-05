﻿using MiddlewaresSandbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Repositories
{
    public class InMemoryErrorsRepository : IErrorsRepository
    {
        private readonly IList<Error> Errors = new List<Error>();
        public Task AddError(Error error)
        {
            Errors.Add(error);

            return Task.CompletedTask;
        }

        public Task<IList<Error>> GetErrors()
        {
            return Task.FromResult(Errors);
        }
    }
}
