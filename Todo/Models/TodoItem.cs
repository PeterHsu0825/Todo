using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Display(Name = "標題")]
        public string? Title { get; set; }

        [Display(Name = "明細")]
        public string? Detail { get; set; }

        [Display(Name = "時間")]
        public DateTime? Date { get; set; }
    }
}
