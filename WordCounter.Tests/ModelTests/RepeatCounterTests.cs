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
      RepeatCounter newRepeatCounter = new RepeatCounter("test");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string testWord = "Snarfle";
      RepeatCounter newRepeatCounter = new RepeatCounter(testWord);
      string result = newRepeatCounter.GetWord();
      Assert.AreEqual(testWord, result);
    }

    [TestMethod]
    public void SetWord_SetsWord_String()
    {
      string testWord = "Barfle";
      RepeatCounter newRepeatCounter = new RepeatCounter(testWord);
      string updatedTestWord = "Snarfle";
      newRepeatCounter.SetWord(updatedTestWord);
      string result = newRepeatCounter.GetWord();
      Assert.AreEqual(updatedTestWord, result);
    }

  }
}