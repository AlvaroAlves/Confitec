using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCuting.Mappings
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            //DtoToModel
            CreateMap<UsuarioModel, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioModel, UsuarioCreateDto>().ReverseMap();
            CreateMap<UsuarioModel, UsuarioUpdateDto>().ReverseMap();
            //EntityToDto
            CreateMap<UsuarioDto, UsuarioEntity>().ReverseMap();
            CreateMap<UsuarioCreateUpdateResultDto, UsuarioEntity>().ReverseMap();
            //ModelToEntity
            CreateMap<UsuarioModel, UsuarioEntity>().ReverseMap();
        }
    }
}