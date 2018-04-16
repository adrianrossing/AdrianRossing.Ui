using System;
using System.Collections.Generic;

namespace AdrianRossing.Ui.Models.Articles
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool Published { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public Uri ArticleUri { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
