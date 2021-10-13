using MoodAnalyserProject;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        //UC4
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
        //end of UC4
        //UC5
        [Test]
        public void GivenMoodAnalyser_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser("Happy");
            object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyzerProject.MoodAnalyze", "MoodAnalyze", "Happy");
            expected.Equals(actual);
        }

        [Test]

        public void GivenMoodAnalyserWrongClassName_ShouldThrowMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyzerProject.MoodAnalyzer", "MoodAnalyzer", "Happy");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [Test]

        public void GivenMoodAnalyserClassNameWithNoProperConstructor_ShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyzerProject.MoodAnalyze", "MoodAnalyzer", "I am happy");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //End of UC5
    }
}