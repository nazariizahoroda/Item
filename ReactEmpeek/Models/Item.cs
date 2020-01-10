using System.ComponentModel.DataAnnotations;

namespace ReactEmpeek.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }

        private Item()
        {
        }

        public Item(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
