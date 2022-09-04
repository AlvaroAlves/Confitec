using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Api.Domain.Dtos.HistoricosEscolares;
using Api.Domain.Interfaces.Services.HistoricosEscolares;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeTypes;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoricosEscolaresController : ControllerBase
    {
        private IHistoricoEscolarService _service;
        private IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        public HistoricosEscolaresController(IHistoricoEscolarService service, IWebHostEnvironment environment, IMapper mapper)
        {
            _service = service;
            _environment = environment;
            _mapper = mapper;
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
        [Route("{id}", Name = "GetHistoricoEscolarById")]
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
        public async Task<ActionResult> Post([FromBody] HistoricoEscolarCreateDto historicoEscolar){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Post(historicoEscolar);
                if(res == null)
                    return BadRequest();
                return Created(new Uri(Url.Link("GetHistoricoEscolarById", new {id = res.Id })), res);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("historico-documento/{historicoId}")]
        public async Task<ActionResult> GetFile(int historicoId)
        {
            var historicoEscolar = await _service.Get(historicoId);
            if (string.IsNullOrEmpty(historicoEscolar.HistoricoUrl))
                return NoContent();
            var filePath = Path.Combine(_environment.ContentRootPath, @"Resources/Files", historicoEscolar.HistoricoUrl);
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
            return File(bytes,  MimeTypeMap.GetMimeType(historicoEscolar.Formato.Replace(".","").ToLower()) , Path.GetFileName(filePath));
        }

        [HttpPost("historico-documento/{historicoId}")]
        public async Task<ActionResult> UploadHistorico(int historicoId){
            try
            {
                var historicoEscolar = _mapper.Map<HistoricoEscolarUpdateDto>(await _service.Get(historicoId));
                
                if(historicoEscolar == null) return NoContent();
                var file = Request.Form.Files[0];
                if(!new List<string>(){".doc", ".pdf"}.Contains(Path.GetExtension(file.FileName)))
                    return StatusCode((int)HttpStatusCode.BadRequest, "Extensão não permitida");
                
                if(file.Length > 0){
                    if(historicoEscolar.HistoricoUrl != null)
                        DeleteHistorico(historicoEscolar.HistoricoUrl);
                    historicoEscolar.HistoricoUrl = await SaveHistorico(file);
                    historicoEscolar.Formato = Path.GetExtension(file.FileName);
                }
                var res = await _service.Put(historicoEscolar);
                if(res == null)
                    return BadRequest();    
                return Ok(res);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [NonAction]
        public void DeleteHistorico(string arquivo){
            var filePath = Path.Combine(_environment.ContentRootPath, @"Resources/Files", arquivo);
            if(System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }

        [NonAction]
        public async Task<string> SaveHistorico(IFormFile file){
            string fileName = new String(Path.GetFileNameWithoutExtension(file.FileName).Take(10).ToArray()).Replace(" ", "_");
            fileName = $"{fileName}{DateTime.UtcNow.ToString("yyyymmssfff")}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_environment.ContentRootPath, @"Resources/Files", fileName);
            using(var fileStream = new FileStream(filePath, FileMode.Create)){
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] HistoricoEscolarUpdateDto historicoEscolar){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var res = await _service.Put(historicoEscolar);
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