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
      RepeatCounter newRepeatCounter = new RepeatCounter();
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

  }
}