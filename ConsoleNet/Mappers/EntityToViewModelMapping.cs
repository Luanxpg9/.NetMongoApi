using AutoMapper;
using ConsoleNet.Entities;
using ConsoleNet.Entities.Enums;

namespace ConsoleNet.Mappers;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<NewsViewModel, News>().ReverseMap();
    }

}
