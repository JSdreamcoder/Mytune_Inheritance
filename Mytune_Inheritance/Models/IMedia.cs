namespace Mytune_Inheritance.Models
{
    public interface IMedia
    {
        public string Title { get; set; }
        public int Runtime { get; set; }

        public SongPlayMethod Method { get; set; }

        public abstract string Play();
     
    }

    public enum SongPlayMethod
    {
        Audio,
        Video,

    }

}
