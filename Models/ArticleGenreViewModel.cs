using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AlwaysLikeThis.Models;

public class ArticleGenreViewModel
{
    public List<Article>? Articles { get; set; }
    public SelectList? Genres { get; set; }
    public string? ArticleGenre { get; set; }
    public string? SearchString { get; set; }}
