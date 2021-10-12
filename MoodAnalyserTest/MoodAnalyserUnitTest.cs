using MoodAnalyserProject;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSad_ShouldReturn_SadMood()
        {
            MoodAnalyser moodtest = new MoodAnalyser("I am in sad Mood");
            string result = moodtest.Analyzer();
            Assert.AreEqual("sad", result);
        }
        [Test]
        public void GivenAny_ShouldReturn_SadMood()
        {
            MoodAnalyser moodtest = new MoodAnalyser("I am in any Mood");
            string result = moodtest.Analyzer();
            Assert.AreEqual("happy", result);
        }
    }
}