using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WikiClase.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        [MaybeNull]
        public byte Image { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Tag")]
        public int IdTags { get; set; }
        public Tag Tag { get; set; }

        
    }
}
