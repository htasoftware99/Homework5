using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Dictionary<TKey, TValue>
    {
        TKey[] _keyarray, _tempkeyarray;
        TValue[] _valuearray, _tempvaluearray;

        public Dictionary()
        {
            _keyarray = new TKey[0];
            _valuearray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempkeyarray = _keyarray;
            _tempvaluearray = _valuearray;

            _keyarray = new TKey[_keyarray.Length + 1];
            _valuearray = new TValue[_keyarray.Length + 1];

            for (int i = 0; i < _tempkeyarray.Length; i++)
            {
                _keyarray[i] = _tempkeyarray[i];
            }

            for (int i = 0; i < _tempvaluearray.Length; i++)
            {
                _valuearray[i] = _tempvaluearray[i];
            }

            _keyarray[_keyarray.Length - 1] = key;
            _valuearray[_valuearray.Length - 1] = value;

            Console.WriteLine(_keyarray[_keyarray.Length - 1]);
            Console.WriteLine(_valuearray[_valuearray.Length - 1]);
        }
    }
}
