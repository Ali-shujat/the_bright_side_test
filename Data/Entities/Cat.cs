using System.ComponentModel.DataAnnotations;

namespace testing.Data.Entities
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Image { get; set; }

        public string? AdditionalInfo { get; set; }

        public string? Breed { get; set; }

        public string? Size { get; set; }

        public string? Eyecolor { get; set; }

        public string? CoatLength { get; set; }

        public string? Gender { get; set; }

        public virtual Person Owner { get; set; }
    }
}
