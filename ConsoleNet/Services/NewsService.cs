using AutoMapper;
using ConsoleNet.Entities;
using ConsoleNet.Entities.Enums;
using ConsoleNet.Infra;

namespace ConsoleNet.Services;

public class NewsService(IMongoRepository<News> newsRepository, IMapper mapper)
{
    public List<NewsViewModel> Get() =>
        mapper.Map<List<NewsViewModel>>(newsRepository.Get());

    public NewsViewModel Get(string id) => 
        mapper.Map<NewsViewModel>(newsRepository.Get(id));

    public NewsViewModel Create(NewsViewModel news)
    {
        var entity = new News(
            news.Hat, news.Title, news.Text, news.Author, news.Image, news.Link, news.Status
            );
        newsRepository.Create(entity);

        return Get(entity.Id);
    }

    public void Update(string id, NewsViewModel newsIn)
    {
        var newsToUpdate = mapper.Map<News>(newsIn);

        newsRepository.Update(id, newsToUpdate);
    }

    public void Delete(string id) => newsRepository.Delete(id);
}
