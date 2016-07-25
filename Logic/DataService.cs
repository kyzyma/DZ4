using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class DataService : IDataService
    {
        private List<int> _data;

        public DataService(int capacity)
        {
            if (capacity < 0 || capacity >= int.MaxValue)
                throw new ArgumentException("Index not exist in list");

            _data = new List<int>(capacity);
        }

        public int ItemsCount => _data?.Count ?? 0;

        public void AddItem(int a)
        {
            _data.Add(a);
        }

        public int GetElementAt(int index)
        {
            if (index < 0 || index >= _data.Count)
                throw new IndexOutOfRangeException("Index not exist in list");

            return _data.ElementAt(index);
        }

        public IEnumerable<int> GetAllData()
        {
            return _data;
        }

        public void RemoveAt(int index)
        {
            if(index < 0 ||index >=_data.Count)
                throw new IndexOutOfRangeException("Index not exist in list");

            _data.RemoveAt(index);
        }

        public void ClearAll()
        {
            _data.Clear();
        }

        public int GetMax()
        {
            if(_data.Count==0) 
                throw new InvalidOperationException("List is empty");

            return _data.Max();
        }
    }
}