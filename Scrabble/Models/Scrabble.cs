using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    private string _word;
    private int _score = 0;
    private static Dictionary<char, int> Letters = new Dictionary<char, int>
    {
      {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1},
      {'r', 1}, {'s', 1}, {'t', 1}, {'d', 2}, {'g', 2}, {'b', 3}, {'c', 3},
      {'m', 3}, {'p', 3}, {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
      {'k', 5}, {'j', 8}, {'x', 8}, {'q', 10}, {'z', 10}, {'_', 0}
    };

    public ScrabbleScore(string word)
    {
      _word = word.ToLower();
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetScore()
    {
      return _score;
    }

    public char[] SplitWord()
    {
      return _word.ToCharArray();
    }

    public void AddScore()
    {
      char[] chars = SplitWord();
      foreach (char c in chars)
      {
        if ((c < 'a' || c > 'z') && c != '_')
        {
          _score = 0;
          break;
        }
        _score += Letters[c];
      }
    }
  }
}
