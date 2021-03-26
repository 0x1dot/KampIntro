using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,S>
    {
        T[] _key;
        S[] _value;

        public MyDictionary()
        {
            _key = new T[0];
            _value = new S[0];
        }

        public void Add(T key, S value)
        {
            T[] _tempArrayK = _key;
            S[] _tempArrayV = _value;

            _key = new T[_key.Length + 1];
            _value = new S[_value.Length + 1];

            for (int i = 0; i < _tempArrayK.Length; i++)
            {
                _key[i] = _tempArrayK[i];
            }

            for (int i = 0; i < _tempArrayV.Length; i++)
            {
                _value[i] = _tempArrayV[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
    }
}
