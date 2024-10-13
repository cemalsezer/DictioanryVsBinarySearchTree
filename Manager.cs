using DictionaryVsBinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictioanryVsBinarySearchTree
{
    public class Manager
    {
        private CustomDictionary customDict;
        private BinarySearchTree bst;

        public Manager()
        {
            customDict = new CustomDictionary();
            bst = new BinarySearchTree();
        }

        public void InsertToDictionary(int key, int value)
        {
            customDict.Insert(key, value);
        }

        public void InsertToBST(int key)
        {
            bst.Insert(key);
        }

        public bool SearchInDictionary(int key)
        {
            return customDict.Search(key);
        }

        public bool SearchInBST(int key)
        {
            return bst.Search(key);
        }
    }
}
