using gfg_algorithms.Searching;


var test1 = new[] { 1, 6, 7, 4, 6 };
var test2 = new[] { 11, 67, 27, 74, 86 };

// Linear search
Console.WriteLine(LinearSearch.Search(test1, 27));
Console.WriteLine(LinearSearch.Search(test2, 27));

// Recursive linear search
Console.WriteLine(LinearSearch.SearchRecursively(test1, 27));
Console.WriteLine(LinearSearch.SearchRecursively(test2, 27));