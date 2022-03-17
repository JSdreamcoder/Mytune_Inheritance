namespace Mytune_Inheritance.Models
{
    public class Song : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public Song()
        {
            Customers = new HashSet<Customer>();
        }

        public int Runtime { get; set; }
        public SongPlayMethod Method { get; set; }

        public string Play()
        {

            return $"Playing the song {Title} on your favourite music platform for {Runtime}.";
        }


    }
}
