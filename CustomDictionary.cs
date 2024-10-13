using System;
using System.Collections.Generic;

namespace DictionaryVsBinarySearchTree
{
    public class CustomDictionary
    {
        private const int Size = 1000000;  // 1 milyon veri kapasitesi
        private LinkedList<KeyValuePair<int, int>>[] items;

        public CustomDictionary()
        {
            items = new LinkedList<KeyValuePair<int, int>>[Size];
        }

        private int GetIndex(int key)
        {
            return key % Size;
        }

        public void Insert(int key, int value)
        {
            int index = GetIndex(key);

            if (items[index] == null)
            {
                items[index] = new LinkedList<KeyValuePair<int, int>>();
            }

            // Anahtarın zaten var olup olmadığını kontrol edin
            foreach (var pair in items[index])
            {
                if (pair.Key == key)
                {
                    // Anahtar zaten varsa, ekleme işlemi yapmayın.
                    return;  // Hata fırlatmak yerine geri dönün
                }
            }

            items[index].AddLast(new KeyValuePair<int, int>(key, value));
        }

        public bool Search(int key)
        {
            int index = GetIndex(key);

            if (items[index] != null)
            {
                foreach (var pair in items[index])
                {
                    if (pair.Key == key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
