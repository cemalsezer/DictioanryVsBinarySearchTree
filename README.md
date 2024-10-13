
# **Dictionary vs Binary Search Tree: Performance Comparison and Time Complexity Analysis**

This project explores the performance and time complexity of two fundamental data structures: **Dictionary** and **Binary Search Tree (BST)**. Using **1 million data points**, we compare the insertion and search operations in both structures to understand their efficiency in real-world scenarios. The project also includes performance tests using **BenchmarkDotNet** to measure the execution times and assess the strengths and weaknesses of each structure.

## **Project Overview**

Data structures play a crucial role in software development, especially when handling large datasets. In this project, we analyze how **Dictionary** and **BST** perform under different conditions, focusing on their:
- **Insertion performance**
- **Search efficiency**
- **Big-O time complexity**

We run tests for both **CustomDictionary** and **BinarySearchTree** implementations to provide a detailed comparison of their performance in terms of speed and complexity.

## **Features**

- **CustomDictionary**: Implements a hash-based dictionary to store key-value pairs with constant time complexity (O(1)) for insertion and search operations.
- **BinarySearchTree**: Implements a binary search tree for ordered data storage, with logarithmic time complexity (O(log n)) for balanced trees and linear time complexity (O(n)) for unbalanced trees.
- **BenchmarkDotNet Integration**: Comprehensive performance testing using BenchmarkDotNet to measure the execution times of both data structures.

## **Performance Comparison**

We conducted tests using **1 million data points** to measure the performance of Dictionary and BST in two key operations:
- **Insertion**
- **Search**

The table below summarizes the results (times in nanoseconds):
<img src="https://github.com/cemalsezer/DictionaryVsBinarySearchTree/blob/master/img/performance_analysis.png" />

## **Big-O Time Complexity**

- **Dictionary**:
  - **Insertion**: O(1)
  - **Search**: O(1)
  
- **Binary Search Tree** (BST):
  - **Insertion**: O(log n) for balanced trees, O(n) for unbalanced trees
  - **Search**: O(log n) for balanced trees, O(n) for unbalanced trees

## **Project Structure**

- `CustomDictionary.cs`: Contains the implementation of a custom dictionary using hash-based storage.
- `BinarySearchTree.cs`: Contains the implementation of a binary search tree for ordered data storage.
- `BenchmarkTest.cs`: Defines the test scenarios and benchmarking for performance analysis.
- `Manager.cs`: Manages the insertion and search operations for both structures, serving as a central point to run tests.

## **Installation & Usage**

1. **Clone the repository:**

```bash
git clone https://github.com/your-username/DictionaryVsBinarySearchTree.git
cd DictionaryVsBinarySearchTree
```

2. **Build and run the project:**

```bash
dotnet build
dotnet run -c Release
```

3. **View Benchmark Results:**
BenchmarkDotNet will generate performance results and export them to the `BenchmarkDotNet.Artifacts` folder.

## **Dependencies**

- **.NET 6.0 or later**
- **BenchmarkDotNet** for performance testing


## **Links**

- [Medium Article on Performance Comparison](https://medium.com/@cemalsezer/dictionary-ve-bst-yapılarının-performans-karşılaştırması-ve-zaman-karmaşıklıkları-dff195a17fde)
