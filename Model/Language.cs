using System.Globalization;

namespace anrouxel.github.io.Model
{
    public class Language
    {
        public CultureInfo cultureInfo { get; set; }
        public string language { get; set; }
        public string image { get; set; }

        public Language(CultureInfo cultureInfo, string language, string image)
        {
            this.cultureInfo = cultureInfo;
            this.language = language;
            this.image = image;
        }
    }
}