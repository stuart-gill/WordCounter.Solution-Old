using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceofRepeatCounter_RepeatCounter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test sentence");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string testSentence = "Snarfle";
      RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
      string result = newRepeatCounter.GetSentence();
      Assert.AreEqual(testSentence, result);
    }

    [TestMethod]
    public void SetSentence_SetsSentence_String()
    {
      string testSentence = "Barfle Snarfle";
      RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
      string updatedTestSentence = "Snarfle Barfle";
      newRepeatCounter.SetSentence(updatedTestSentence);
      string result = newRepeatCounter.GetSentence();
      Assert.AreEqual(updatedTestSentence, result);
    }

    [TestMethod]
    public void CountWordInSentence_CountsWordsInSentence_Int()
    {
      string testWord = "tarfle";
      string testSentence = "barfle snarfle tarfle darfle tarfle";
      RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
      newRepeatCounter.CountWordInSentence(testWord);
      int result = newRepeatCounter.CountWordInSentence(testWord);
      Assert.AreEqual(2, result);
    }


  }
}