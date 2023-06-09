namespace prueba.Model
{
    public class Dictionary
    {
        public _meanings meanings { get; set; }

    }
    public class _meanings
    {
        public string? partOfSpeech { get; set; }
        public  definitions[] definitions { get; set; }

        public List<string> synonyms { get; set; }

        public List<string>? antonyms { get; set; }


    }
     
    public class definitions
    {
        public string? definition { get; set; }
        public   List<string>? synonyms { get; set; }
        public List<string>? antonyms { get; set; }
        public string? example { get; set; }

    }


}
