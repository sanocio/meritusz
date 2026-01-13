namespace backend.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string? Mission { get; set; }
        public string? History { get; set; }
    }
}
