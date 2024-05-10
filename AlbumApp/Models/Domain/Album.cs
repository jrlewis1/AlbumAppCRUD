namespace AlbumApp.Models.Domain
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public long Price { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
