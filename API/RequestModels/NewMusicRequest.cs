namespace API.RequestModels
{
    public class NewMusicRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Image_Url { get; set; }
        public string Audio_Url { get; set; }
        public string Thumb { get; set; }
        public string CreatedBy { get; set; }

    }
}