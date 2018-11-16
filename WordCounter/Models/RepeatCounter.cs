using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    public List<string> stringList;
    public int counter;  
    
    public RepeatCounter (string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public int CountWordInSentence(string targetWord)
    {
       counter = 0;      
       stringList = _sentence.Split().ToList();
       foreach(string word in stringList)
       {
         if (word == targetWord)
         {
           counter+=1;
         }
       }
       return counter;
     }

     public bool IsSentence(string sentence)
     {
       stringList = _sentence.Split().ToList();
       foreach(string word in stringList)
       {
         char[] characters = word.ToCharArray();
         foreach(char letter in characters)
         {
           bool result;
           result = Char.IsLetter(letter);
           if (result == false)
           {
             return false;
           }
         }
       }
       return true;
     }
   }
 }