using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoreDev.Domain.Entities;
using MoreDev.Infra.Data.SqlServer.Context;

namespace MoreDev.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloMoreDevController : ControllerBase
    {
        private readonly ILogger<HelloMoreDevController> _logger;
        private readonly MoreDevContext _context;
        private readonly EstudoService _estudo;

        public HelloMoreDevController(ILogger<HelloMoreDevController> logger, MoreDevContext context, EstudoService estudo)
        {
            _logger = logger;
            _context = context;
            _estudo = estudo;
        }

        [HttpGet]
        public async Task<ActionResult<List<HelloMoreDevEntity>>> Get()
        {
            return await _context.HelloMoreDev.ToListAsync();
        }

        [HttpGet("estudo")]
        public ActionResult<List<EstudoEntity>> GetEstudo()
        {
            return _estudo.EstudoTeste();
        }

        [HttpGet("segundo")]
        public async Task<ActionResult<string>> GetSegundo()
        {
            
            using (var connection = _context.Database.GetDbConnection())
            {
                
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO HelloMoreDev Values(newid(),'Rafaela', 27)";
                    var result = await command.ExecuteNonQueryAsync();
                }
            }

            return Ok("Deu certo");
        }

        [HttpGet("terceiro")]
        public async Task<ActionResult<string>> GetTerceiro()
        {
            using (var connection = _context.Database.GetDbConnection())
            {
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO HelloMoreDevTest Values(newid(),'Rafaela', 27)";
                    var result = await command.ExecuteNonQueryAsync();
                }
            }

            return Ok("Deu certo");
        }
    }
}
