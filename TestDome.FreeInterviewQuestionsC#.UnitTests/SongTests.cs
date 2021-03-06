using Xunit;

namespace TestDome.FreeInterviewQuestionsC.UnitTests
{
    public class SongTests
    {
        [Fact]
        public void DetectsRepeatingPlaylistWhenLastSongPointsToFirst()
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
        
            first.NextSong = second;
            second.NextSong = first;

            Assert.True(first.IsRepeatingPlaylist());
        }

        [Fact]
        public void NotARepeatingPlaylistWhenLastSongPointsToNull()
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
        
            first.NextSong = second;

            Assert.False(first.IsRepeatingPlaylist());
        }
    }
}