namespace GameLibrary.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Genre
    {
        public int GenreID {  get; set; }
        public int DeveloperID {  get; set; }
        public int GameID {  get; set; }
        public Genre? Genre { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Game Game { get; set; }
    }
}
