namespace gorillaspace.Models
{
    using System.ComponentModel.DataAnnotations;
    using gorillaspace.Models;

    public class ToDoItem : TenantModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}