using System;

namespace TestDome.FreeInterviewQuestionsC
{
    /*
    A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, 
    the playlist will end with the last song which points to null.

    Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.
    */
    public class Song
    {
        private string name;
        public Song NextSong { get; set; }
    
        public Song(string name)
        {
            this.name = name;
        }
    
        public bool IsRepeatingPlaylist()
        {
            Song nextSong = this.NextSong;
            Song followingNextSong = nextSong == null ? null : nextSong.NextSong;
            while (followingNextSong != null) {
                if (nextSong == this || nextSong == followingNextSong) // points to self or next song points to self
                    return true;
                nextSong = nextSong.NextSong;
                followingNextSong = followingNextSong.NextSong;
                if (followingNextSong != null)
                    followingNextSong = followingNextSong.NextSong;
            }
            return false;
        }
    
        public static void Execute(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
        
            first.NextSong = second;
            second.NextSong = first;
        
            Console.WriteLine(first.IsRepeatingPlaylist());
        }
    }
}