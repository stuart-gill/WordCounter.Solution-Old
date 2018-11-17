using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
      string testSentence = "Snarfle Darfle";
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
    public void IsSentence_ChecksIfIsSentence_Bool()
    {
      string testSentence = "sentence contains nonalphabetic characters dd44dd" ;
      RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
      newRepeatCounter.IsSentence(testSentence);
      bool result = newRepeatCounter.IsSentence(testSentence);
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void SentenceToLowerCase_ChecksForLowerCase_Bool()
    {
      string testSentence = "This Sentence Has Upper Case Letters";
      RepeatCounter newRepeatCounter = new RepeatCounter(testSentence);
      newRepeatCounter.SentenceToLowerCase(testSentence);
      string resultingSentence = newRepeatCounter.SentenceToLowerCase(testSentence);
      bool result = resultingSentence.Any(char.IsUpper);
      Assert.AreEqual(false, result);
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