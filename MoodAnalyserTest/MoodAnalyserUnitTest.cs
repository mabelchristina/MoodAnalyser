using MoodAnalyserProject;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);

        }
        [Test]
        public void GivenWrongClassName_ShouldThrowException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProject.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [Test]
        public void GivenClassConstructerNotProper_ShouldThrowException()
        {
            string expected = "Constructor not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProject.MoodAnalyze", "MoodAnalyzer");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}