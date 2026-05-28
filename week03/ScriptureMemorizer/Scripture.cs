using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            
            // Split text by spaces and add each word to our collection
            string[] splitWords = text.Split(' ');
            foreach (string wordText in splitWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            
            // Stretch Goal Logic: Build a list of indices that aren't already hidden
            List<int> visibleIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                {
                    visibleIndices.Add(i);
                }
            }

            // If there are fewer words left than requested, just hide what's left
            int actualToHide = Math.Min(numberToHide, visibleIndices.Count);

            for (int i = 0; i < actualToHide; i++)
            {
                int randomIndexInList = random.Next(visibleIndices.Count);
                int actualWordIndex = visibleIndices[randomIndexInList];
                
                _words[actualWordIndex].Hide();
                
                // Remove from local list so we don't accidentally pick it again in this loop execution
                visibleIndices.RemoveAt(randomIndexInList);
            }
        }

        public string GetDisplayText()
        {
            List<string> displayedWords = new List<string>();
            foreach (Word word in _words)
            {
                displayedWords.Add(word.GetDisplayText());
            }

            // Combine words back together into a single cohesive paragraph
            return $"{_reference.GetDisplayText()} - {string.Join(" ", displayedWords)}";
        }

        public bool IsCompletelyHidden()
        {
            // If any word is NOT hidden, return false
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}