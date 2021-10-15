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

        //UC6
        [Test]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {
            //Arrange
            string className = "MoodAnalyzer.MoodAnalyser";
            string constructor = "MoodAnalyser";
            MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
            //Act
            object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructor, "HAPPY");
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TestCase-6.2
        [Test]
        public void Given_Wrong_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructorName, "HAPPY");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        //TC 6.3:-Pass Wrong Constructor parameter, cactch the Exception and throw indicating No such method Error
        [Test]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructorName, "HAPPY");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
    }
}