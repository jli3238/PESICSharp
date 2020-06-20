"# PESICSharp" 

Exercise 1: 
Write 2 functions (each with a different implementation) which accept a string and return a string containing the same characters as the input string -- but in a random order. Compare these implementations and describe why you might prefer one implementation over another (and under what circumstances). One of the implementations should use the System.Random type and its Next(int minValue, int maxValue) overload, while the other implementation isn't constrained to System.Random usage.

Deliverables: 
C# source file(s), optionally including a Visual Studio solution and project(s) as you see fit
A narrative comparing your implementations

********
A C# solution repository at https://github.com/jli3238/PESICSharp is created for demonstrating the two implementations of string randomization. It is a C# windows console application.

How to run/test the application:
1. Click the green "Start" button on the header menu to run this app on the console;
2. Follow the console prompt to enter a string and hit "Enter" on the keyborad to see the two output strings randomized by the two functions.

Comparison of these two implementations: 
1. RandomizeBySystemRandomFYShuffleCall: It uses the standard Random provided in c# along with the Fisher-Yates Shuffle. The standard RNG is not quite a perfect random and there is evidence that it could be better. The Fisher-Yates Shuffle, however, is optimal in being an efficient uniform shuffle (i.e. all permutations have an equal probability). The time complexity is O(n), assuming random number generating is of O(1).
2. RandomizeBySystemRandomSortCall: This one also uses Random. It assigns each element in the array with a random element in a toset as a "key". As the key is part of a toset, we sort it to create an alternative order. This is also uniformly random, but the time complexity is O(n log(n)), assuming random number generating is of less than O(log(n)).

The comparison of the two implementations have been added below the functions in file "program.cs".