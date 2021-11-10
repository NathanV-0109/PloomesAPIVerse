
namespace MyVerse.Models
{
    /// <summary>
    /// Anemic Class
    /// Class that has no behavior
    /// Class of Biblics Verses
    /// </summary>
    public class Verses
    {
        public int id { get; set; }
        public string Book { get; set; }
        public int Verse { get; set; }
        public int Chapter { get; set; }
        public string Text { get; set; }
    }
}
