namespace dofus_unity_rendering_back.Models.Metadata.Translation
{
    public class TranslatedLabel
    {
        public TranslatedLabel(int id, string languageCode, string label)
        {
            this.id = id;
            this.languageCode = languageCode;
            this.label = label;
        }

        public int id { get; set; }
        public string languageCode { get; set; }
        public string label { get; set; }


    }
}
