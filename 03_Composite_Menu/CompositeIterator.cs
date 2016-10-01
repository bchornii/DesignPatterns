using System;
using System.Collections;
using System.Collections.Generic;

namespace _03_Composite_Menu
{
    public class CompositeIterator : IEnumerator
    {
        private readonly Stack<IEnumerator> _menuComponents = new Stack<IEnumerator>();
        public CompositeIterator(IEnumerator enumerator)
        {
            _menuComponents.Push(enumerator);
        }

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; }
    }
}