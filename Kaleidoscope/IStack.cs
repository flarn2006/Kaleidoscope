using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kaleidoscope
{
    interface IStack<T> : IEnumerable<T>
    {
        void Push(T item);
        T Pop();
        void Clear();
        int Count { get; }
    }

    /// <summary>
    /// Stub class to enable use of a regular stack as an IStack instance
    /// </summary>
    class Stack<T> : System.Collections.Generic.Stack<T>, IStack<T>
    {
        public Stack() : base() { }
        public Stack(int capacity) : base(capacity) { }
        public Stack(IEnumerable<T> collection) : base(collection) { }
    }
}
