using ConsoleNet.Entities;
using MongoDB.Driver;

namespace ConsoleNet.Infra;

public interface IMongoRepository<T>
{
    List<T> Get();
    T Get(string id);
    T Create (T entity);
    void Update(string id, T entity);
    void Delete(string id);
}
public class MongoRepository<T> : IMongoRepository<T> where T : BaseEntity
{
    private readonly IMongoCollection<T> _model;

    public MongoRepository(IDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);

        _model = database.GetCollection<T>(typeof(T).Name.ToLower());
    }

    public T Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<T> Get()
    {
        throw new NotImplementedException();
    }

    public T Get(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(string id, T entity)
    {
        throw new NotImplementedException();
    }
}
