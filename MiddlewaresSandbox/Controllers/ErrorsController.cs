using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddlewaresSandbox.Models;
using MiddlewaresSandbox.Repositories;

namespace MiddlewaresSandbox.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ErrorsController : ControllerBase
    {
        private readonly IErrorsRepository ErrorsRepository;

        public ErrorsController(IErrorsRepository errorsRepository)
        {
            ErrorsRepository = errorsRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Error>> Get()
        {
            return await ErrorsRepository.GetErrors();
        }
    }
}