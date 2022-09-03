using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.HistoricosEscolares;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCuting.Mappings
{
    public class HistoricoEscolarProfile : Profile
    {
        public HistoricoEscolarProfile()
        {
            //DtoToModel
            CreateMap<HistoricoEscolarModel, HistoricoEscolarDto>().ReverseMap();
            CreateMap<HistoricoEscolarModel, HistoricoEscolarCreateDto>().ReverseMap();
            CreateMap<HistoricoEscolarModel, HistoricoEscolarUpdateDto>().ReverseMap();
            //EntityToDto
            CreateMap<HistoricoEscolarDto, HistoricoEscolarEntity>().ReverseMap();
            CreateMap<HistoricoEscolarCreateUpdateResultDto, HistoricoEscolarEntity>().ReverseMap();
            //ModelToEntity
            CreateMap<HistoricoEscolarModel, HistoricoEscolarEntity>().ReverseMap();
        }
        
    }
}