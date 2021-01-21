using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOOP_Lab6Library
{
    public class MyList<Types> : IEnumerable<Types>
    {
        private const int def_count = 3;
        private int currentCapacity;

        private Types[] items;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Types Last
        {
            get { return items[Count - 1]; }
        }

        public int Capacity
        {
            get { return items.Length; }
            set
            {
                if (value < count) value = count;
                if (value != items.Length)
                {
                    Types[] newItems = new Types[value];
                    Array.Copy(items, 0, newItems, 0, count);
                    items = newItems;
                }
            }
        }

        public Types this[int index]
        {
            get
            {
                if (index > count - 1) throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index > count - 1) throw new IndexOutOfRangeException();
                items[index] = value;
            }
        }

        public MyList(int capacity = def_count)
        {
            currentCapacity = capacity;
            items = new Types[currentCapacity];
        }

        public void Add(Types item)
        {
            if (count == Capacity) Capacity = count * 2;
            items[count++] = item;
        }

        public void Clear()
        {
            count = 0;
            items = new Types[currentCapacity];
        }

        public void Remove(Types item)
        {
            int tempCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (Equals(items[i], item)) tempCount = i;
            }
            RemoveAt(tempCount);

        }

        public void RemoveAt(int index)
        {
            Types[] newItems = new Types[items.Length - 1];
            Array.Copy(items, 0, newItems, 0, index);
            Array.Copy(items, index + 1, newItems, index, items.Length - 1 - index);
            count--;
            items = newItems;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<Types> IEnumerable<Types>.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
    }
}
