using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PacientesApi.Modules.Pacientes.Interface;
using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Modules.Pacientes.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : Controller
    {
        private readonly ILogger<PacienteController> _logger;
        private readonly IPacienteService _pacienteService;

        public PacienteController(ILogger<PacienteController> logger, IPacienteService pacienteService)
        {
            _logger = logger;
            _pacienteService = pacienteService;
        }

        // GET: api/paciente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetAll()
        {
            var pacientes = await _pacienteService.GetAll();
            return Ok(pacientes);
        }

        // GET: api/paciente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetById(int id)
        {
            var paciente = await _pacienteService.GetById(id);
            if (paciente == null)
                return NotFound();
            return Ok(paciente);
        }

        // POST: api/paciente
        [HttpPost]
        public async Task<ActionResult<Paciente>> Create(Paciente paciente)
        {
            var created = await _pacienteService.Create(paciente);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/paciente/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Paciente>> Update(int id, Paciente paciente)
        {
            var updated = await _pacienteService.Update(id, paciente);
            if (updated == null)
                return NotFound();
            return Ok(updated);
        }

        // DELETE: api/paciente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _pacienteService.Delete(id);
            if (!result)
                return NotFound();
            return Ok(result);
        }

    }
}