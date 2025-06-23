using AutoMapper;
using ConsoleNet.Entities;
using ConsoleNet.Entities.Enums;

namespace ConsoleNet.Mappers;

public class EntityToViewModelMapping : Profile
{
    public EntityToViewModelMapping()
    {
        CreateMap<NewsViewModel, News>().ReverseMap();
    }

}
