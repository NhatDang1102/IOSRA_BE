using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Story : AuditableEntity
    {
        public string StoryId { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = default!;
        public string AuthorId { get; set; } = default!;
        public string? Desc { get; set; }
        public string? CoverUrl { get; set; }
        public int Status { get; set; }
        public bool IsPremium { get; set; }


        public Author Author { get; set; } = default!;
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
        public ICollection<StoryTag> StoryTags { get; set; } = new List<StoryTag>();
        public ICollection<FavoriteStory> FavoritedBy { get; set; } = new List<FavoriteStory>();
    }
}
