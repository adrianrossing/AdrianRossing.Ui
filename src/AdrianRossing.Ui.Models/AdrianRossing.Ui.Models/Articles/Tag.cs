using System;
using System.Collections.Generic;

namespace AdrianRossing.Ui.Models.Articles
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}