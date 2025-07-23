using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Patterns.Behavioral.Iterator
{
    internal class WordsCollection : IEnumerable<string>
    {
        private List<string> _words = new List<string>();

        public void AddWord(string word) => _words.Add(word);

        public IEnumerator<string> GetEnumerator() => new AlphabeticalIterator(_words);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class AlphabeticalIterator : IEnumerator<string>
        {
            private List<string> _words;
            private int _position = -1;

            public AlphabeticalIterator(List<string> words) => _words = words.OrderBy(w => w).ToList();

            public string Current => _words[_position];
            object IEnumerator.Current => Current;

            public bool MoveNext() => ++_position < _words.Count;
            public void Reset() => _position = -1;
            public void Dispose() { }
        }
    }
}
