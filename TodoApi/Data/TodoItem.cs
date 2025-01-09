using System.ComponentModel.DataAnnotations;

namespace TodoApi.Data
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(400)]
        public string Title { get; set; } = "";

        public bool Done { get; set; }
    }
}
