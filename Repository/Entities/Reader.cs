using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Reader : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public string? Bio { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthdate { get; set; }


        public string? LastStoryId { get; set; }
        public string? LastChapterId { get; set; }
        public string? LastLangId { get; set; }


        public Account Account { get; set; } = default!;
        public ICollection<FavoriteStory> FavoriteStories { get; set; } = new List<FavoriteStory>();
    }
}
