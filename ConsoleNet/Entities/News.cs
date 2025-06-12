using ConsoleNet.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleNet.Entities;

public class News(string hat, string title, string text, string author, string img, string link, Status status) : BaseEntity
{
    [BsonElement("hat")]
    public string Hat { get; private set; } = hat;
    [BsonElement("title")]
    public string Title { get; private set; } = title;
    [BsonElement("text")]
    public string Text { get; private set; } = text;
    [BsonElement("author")]
    public string Author { get; private set; } = author;
    [BsonElement("img")]
    public string Image { get; private set; } = img;
    [BsonElement("link")]
    public string Link { get; private set; } = link;
    [BsonElement("publishDate")]
    public DateTime PublishDate = DateTime.Now;
    [BsonElement("active")]
    public Status Status { get; private set; } = status;

    public Status ChangeStatus (Status status)
    {
        Status = status;
        return Status;
    }
}
