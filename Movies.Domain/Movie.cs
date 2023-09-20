namespace Movies.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinimumAge { get; set; }
        public string Director{ get; set; }
        public int MinutesDuration { get; set; }
    }
}