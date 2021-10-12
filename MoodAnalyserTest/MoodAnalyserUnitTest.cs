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
        [Test]
        public void GivenEmpty_Shouldthrow_CustomException()
        {
            MoodAnalyser moodtest = new MoodAnalyser(" ");
            string result = moodtest.Analyzer();
            Assert.AreEqual("happy", result);
        }
        [Test]
        public void GivenNull_Shouldthrow_CustomException()
        {
            MoodAnalyser moodtest = new MoodAnalyser(null);
            string result = moodtest.Analyzer();
            Assert.AreEqual("happy", result);
        }
    }
}