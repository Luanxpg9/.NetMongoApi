﻿namespace ConsoleNet.Entities.Enums;

public class NewsViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Hat { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;
    public Status Status { get; set; } = Status.Active;

}
