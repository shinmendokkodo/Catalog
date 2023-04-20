using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        [Required]
        public string Name { get; init; }

        public string Description { get; init; }

        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}