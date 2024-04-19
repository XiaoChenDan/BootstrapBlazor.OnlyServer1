using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.OnlyServer1.Data
{
    public class TreeFoo
    {
        [Key]
        [NotNull]
        public string? Id { get; set; }

        public string? ParentId { get; set; }

        [Required]
        [NotNull]
        public string? Text { get; set; }

        public string Icon { get; set; } = "fa-solid fa-font-awesome";

        public bool IsActive { get; set; }
    }
}
