//         1
//       /   \
//      2     3
//     / \     \
//    4   5     6
using Backend;

/**var root = new BinaryNode<int>(1,
    new BinaryNode<int>(2, new BinaryNode<int>(4), new BinaryNode<int>(5)),
    new BinaryNode<int>(3, null, new BinaryNode<int>(6)));*/

var root = BinaryTreeFile.Load("tree.txt");

Console.WriteLine("Pre-Order =>");
BinaryTreeOps.PreOrder(root, x => Console.Write($"{x} "));
Console.WriteLine("\n\nIn-Order =>");
BinaryTreeOps.InOrder(root, x => Console.Write($"{x} "));
Console.WriteLine("\n\nPost-Order =>");
BinaryTreeOps.PostOrder(root, x => Console.Write($"{x} "));
Console.WriteLine("\n\nLevelOrder =>");
BinaryTreeOps.LevelOrder(root, x => Console.Write($"{x} "));
Console.WriteLine("\n\nPrintSideways =>");
BinaryTreeOps.PrintSideways(root, 0);
