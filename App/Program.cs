﻿using System;
using Library;
using static Library.Class1;

class Program
{
    static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Add(10);
        tree.Add(20);
        tree.Add(3);
        tree.Add(3);
        tree.Add(3);
        tree.Add(1);

        Console.WriteLine("Чи містить дерево 7? " + tree.Contains(7));
        Console.WriteLine("Чи містить дерево 2? " + tree.Contains(8));

        object[] treeArray = tree.ToArray();
        Console.WriteLine("Елементи дерева");
        foreach(var item in treeArray)
        {
            Console.Write(item + " ");
        }

        tree.Clear();
        Console.WriteLine("Після очищення дерева:");
        Console.WriteLine("Кількість елементів: " + tree.Count);
    }
}