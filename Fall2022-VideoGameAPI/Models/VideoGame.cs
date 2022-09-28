namespace Fall2022_VideoGameAPI.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StudioId { get; set; }
        public virtual Studio Studio { get; set; } //will become its own model
        public virtual MainCharacter MainCharacter { get; set; }
        //list of tags (categories)
    }
}
