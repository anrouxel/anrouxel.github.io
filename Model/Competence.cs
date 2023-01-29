namespace anrouxel.github.io.Model
{
    public class Competence
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Level { get; set; }

        public Competence(string Name, string Category, double Level) {
            this.Name = Name;
            this.Category = Category;
            this.Level = Level;
        }
    }
}