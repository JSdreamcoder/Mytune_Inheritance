namespace Mytune_Inheritance.Models
{
    public class Artist : User
    {
        
        public ICollection<Song> ComposedSongs { get; set; }

        public Artist()
        {
            
            ComposedSongs = new HashSet<Song>();
        }

        public override string GenerateEmail()
        {
          
            string ArtistEmail = "A" + base.GenerateEmail();
            return ArtistEmail;
        }

    }
}
