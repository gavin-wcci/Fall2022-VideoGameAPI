namespace Fall2022_VideoGameAPI.Models
{
    public class MainCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VideoGameId { get; set; } //this value is the "foreign key" that will be pointing to a video game in another table
        public virtual VideoGame VideoGame { get; set; } //this is the virtual video game object
    }
}
