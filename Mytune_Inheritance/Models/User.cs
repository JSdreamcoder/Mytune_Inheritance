namespace Mytune_Inheritance.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<IMedia> Collection { get; set; }

        public User()
        {
            Collection = new HashSet<IMedia>();
        }


        public virtual string GenerateEmail()
        {
            string a = (Id + Name).ToString();
            string result = a + "@mytune.com";
            return result;
        }

        public string Binge(IMedia song)
        {
            return song.Play();
        }



    }
}
