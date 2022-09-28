namespace Fall2022_VideoGameAPI.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        //video games made by this studio. What do we need? Answer: A collection!
        public virtual List<VideoGame> VideoGames { get; set; }
    }
}
