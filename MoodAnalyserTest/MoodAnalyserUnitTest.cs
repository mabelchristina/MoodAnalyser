using MoodAnalyserProject;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSad_ShouldReturn_SadMood()
        {
            MoodAnalyser moodtest = new MoodAnalyser();
            string result = moodtest.Analyzer("I am in sad Mood");
            Assert.AreEqual("sad", result);
        }
        [Test]
        public void GivenAny_ShouldReturn_SadMood()
        {
            MoodAnalyser moodtest = new MoodAnalyser();
            string result = moodtest.Analyzer("I am in any Mood");
            Assert.AreEqual("happy", result);
        }
    }
}