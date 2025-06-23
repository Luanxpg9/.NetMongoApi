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

    public T Get(string id) => _model.Find(e => e.Id == id).FirstOrDefault();

    // Get all
    public List<T> Get() => _model.Find(e => true).ToList();

    public T Create(T entity)
    {
        _model.InsertOne(entity);

        return entity;
    }

    public void Update(string id, T entity) => _model.ReplaceOne(e => e.Id == id, entity);

    public void Delete(string id) => _model.DeleteOne(e => e.Id == id);
}
