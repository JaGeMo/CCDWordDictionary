using System;
using System.Collections.Generic;
using System.IO;

namespace WordDictionary.Utils
{
    public class DictionaryUtils
    {
        private List<string> _dictionary;
        private String[] lines;

        public List<string> GetAllQuizQuestions()
        {
            return _dictionary;
        }

        public List<string> ReadDictionaryFromFile(String filename)
        {
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                //ToDo 
            }

            return (_dictionary = new List<string>(lines));
        }

    }
}
