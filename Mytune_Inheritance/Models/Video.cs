namespace Mytune_Inheritance.Models
{
    public class Video : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public Video()
        {
            Customers = new HashSet<Customer>();
        }

        public int Runtime { get; set; }
        public SongPlayMethod Method { get; set; }

        public string Play()
        {

            return $"Watching {Title} on your inadequate viewing screen for {Runtime}.";
        }
    }
}
