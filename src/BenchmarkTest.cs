using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictioanryVsBinarySearchTree
{
    public class BenchmarkTest
    {
        private Manager manager;
        private int[] testData;

        [Params(1000000)]  // 1 milyon veri üzerinde test
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            manager = new Manager();
            testData = new int[N];
            Random rand = new Random();

            // 1 milyon veri oluşturup her iki yapıya da ekle
            for (int i = 0; i < N; i++)
            {
                testData[i] = rand.Next(1, 10000000);
                manager.InsertToDictionary(testData[i], testData[i]);
                manager.InsertToBST(testData[i]);
            }
        }

        [Benchmark]
        public void InsertToDictionary()
        {
            manager.InsertToDictionary(N + 1, N + 1);  // Benzersiz bir anahtar ile veri ekleyin
        }

        [Benchmark]
        public void SearchInDictionary()
        {
            manager.SearchInDictionary(testData[N / 2]);  // Var olan bir anahtarı arayın
        }

        [Benchmark]
        public void InsertToBST()
        {
            manager.InsertToBST(N + 1);  // Benzersiz bir anahtar ile veri ekleyin
        }

        [Benchmark]
        public void SearchInBST()
        {
            manager.SearchInBST(testData[N / 2]);  // Var olan bir anahtarı arayın
        }

    }
}
