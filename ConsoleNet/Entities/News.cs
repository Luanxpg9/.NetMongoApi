using ConsoleNet.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleNet.Entities;

public class News : BaseEntity
{
    public News(string Hat, string Title, string Text, string Author, string Img, string Link, Status Status)
    {
        this.Hat = Hat;
        this.Title = Title;
        this.Text = Text;
        this.Author = Author;
        this.Image = Img;
        this.Link = Link;
        this.Status = Status;
    }

    public News() { }
    

    [BsonElement("hat")]
    public string Hat { get; set; }
    [BsonElement("title")]
    public string Title { get; set; }
    [BsonElement("text")]
    public string Text { get; set; }
    [BsonElement("author")]
    public string Author { get; set; }
    [BsonElement("img")]
    public string Image { get; set; }
    [BsonElement("link")]
    public string Link { get; set; }
    [BsonElement("publishDate")]
    public DateTime PublishDate = DateTime.Now;
    [BsonElement("active")]
    public Status Status { get; set; }

    public Status ChangeStatus (Status status)
    {
        Status = status;
        return Status;
    }
}
