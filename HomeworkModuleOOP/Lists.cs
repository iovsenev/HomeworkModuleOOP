﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public abstract class Lists<T>
    {
        protected List<T> _list = new List<T>();
        public int Count { get { return _list.Count; } }
        public List<T> List { get { return _list; } }

        public void Add(T obj)
        {
            _list.Add(obj);
        }

        public void Remove(int index)
        {
            _list.RemoveAt(index);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _list.Count; i++)
            {
                if (i < _list.Count - 1)
                    stringBuilder.Append($"{i + 1}: {_list[i].ToString()},\n");
                else
                    stringBuilder.Append($"{i + 1}: {_list[i].ToString()}");
            }
            return stringBuilder.ToString();
        }
    }
}
