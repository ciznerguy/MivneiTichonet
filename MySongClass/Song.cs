

namespace MySongClass
{
    public class Song
    {
        private string songTitle;
        private int genre;
        private int length;
        private int collection;

        public Song()
        {
        }


        public Song(string songTitle, int genre, int length)
        {
            this.songTitle = songTitle;
            this.genre = genre;
            this.length = length;
        }

        public string GetSongTitle()
        {
            return songTitle;
        }

        public void SetSongTitle(string value)
        {
            this.songTitle = value;
        }

        public int GetGenre()
        {
            return genre;
        }

        public void SetGenre(int value)
        {
            genre = value;
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int value)
        {
            length = value;
        }

        public int GetCollection()
        {
            return collection;
        }

        public void SetCollection(int value)
        {
            collection = value;
        }

        public override string ToString()
        {
            return "Song Title " + songTitle + " Genre Code " + genre + " Length " + length;
        }
    }
}
