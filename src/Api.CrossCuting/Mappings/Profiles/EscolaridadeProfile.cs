using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Escolaridades;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCuting.Mappings
{
    public class EscolaridadeProfile: Profile
    {
        public EscolaridadeProfile()
        {
            //DtoToModel
            CreateMap<EscolaridadeModel, EscolaridadeDto>().ReverseMap();
            CreateMap<EscolaridadeModel, EscolaridadeCreateDto>().ReverseMap();
            CreateMap<EscolaridadeModel, EscolaridadeUpdateDto>().ReverseMap();
            //EntityToDto
            CreateMap<EscolaridadeDto, EscolaridadeEntity>().ReverseMap();
            CreateMap<EscolaridadeCreateUpdateResultDto, EscolaridadeEntity>().ReverseMap();
            //ModelToEntity
            CreateMap<EscolaridadeModel, EscolaridadeEntity>().ReverseMap();
        }
    }
}