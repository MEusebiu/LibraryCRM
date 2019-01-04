using System.ComponentModel.DataAnnotations;

namespace LibraryCRM.DataContext.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
