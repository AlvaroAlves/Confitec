using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Escolaridades;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Escolaridades;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EscolaridadesController : ControllerBase
    {
        private IEscolaridadeService _service;
        public EscolaridadesController(IEscolaridadeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetEscolaridadeById")]
        public async Task<ActionResult> Get(int id){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EscolaridadeCreateDto escolaridade){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Post(escolaridade);
                if(res == null)
                    return BadRequest();
                return Created(new Uri(Url.Link("GetEscolaridadeById", new {id = res.Id })), res);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] EscolaridadeUpdateDto escolaridade){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Put(escolaridade);
                if(res == null)
                    return BadRequest();    
                return Ok(res);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}