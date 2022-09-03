using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioService _service;
        public UsuariosController(IUsuarioService service)
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
        [Route("{id}", Name = "GetUsuarioById")]
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
        public async Task<ActionResult> Post([FromBody] UsuarioCreateDto usuario){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Post(usuario);
                if(res == null)
                    return BadRequest();
                return Created(new Uri(Url.Link("GetUsuarioById", new {id = res.Id })), res);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UsuarioUpdateDto usuario){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Put(usuario);
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