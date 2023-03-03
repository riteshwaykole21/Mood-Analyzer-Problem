using MoodAnalyzer;

namespace MoodanalizerTest
{
    public class Tests
    {
      //  MoodAnaylizerProblem moodAnalyzer = new MoodAnaylizerProblem();

        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            MoodAnaylizerProblem moodAnalyzer = new MoodAnaylizerProblem("I Am In Sad Mood");
            string result = moodAnalyzer.AnaylseMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnaylizerProblem moodAnalyzer = new MoodAnaylizerProblem("I Am In Happy Mood");
            string result = moodAnalyzer.AnaylseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}