# Data Structure Challenge


## Instructions

- Select and complete enough code challenges to accumulate 10 points. (or more!)
- Every challenge is worth a specified amount of points related to its complexity.
- Implement each challenge into Visual Studio within separate console applications. If you wish to do a whiteboard, you may. 
- Include unit tests with your code submissions. (write tests to confirm all basic functionality and 1 or 2 edge cases)
- A readme is required. Provide the same basic information included as a coding challenge (including time and efficiency!)
 Commit Often. 
- The problem statements are in cases vague in order for you to clarify your understanding of the problem with your instructional team.
- Each challenge will be a new entry into your `Challenges` folder in your `Data Structures and Algorithms` repo. Update your table of contents and submit a ***single*** PR that contains all of your challenges. 
- You may receive up to 5 Extra Credit points max by doing an additional 10 points worth of coding challenges. 

## Problem Set

### Calculate the height of a binary tree (4 Points)
Implement a method with the following signature `int CalculateBinaryTreeHeight(Node root)` that calculates the height
of a binary tree.

_Hint: The height of a binary tree is the height of its root_

#### Stretch Goal (1 Additional Point)
Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.

### Check if a binary tree is Balanced (3 Points)
Implement a method with the following signature `bool IsBinaryTreeBalanced(Node root)` that determines if a binary tree is balanced.

_Reminder: We define a balanced binary tree as a binary tree in which the depth of the two subtrees of every node never differ by more than 1._

### Determine if two values in a binary tree have an ancestry relationship. (3 Points)
Implement a method with the following signature `bool IsAncestor(int A, int B, Node root)` that returns true if the value A is an ancestor of the value B in the provided binary tree; the function will return false otherwise.

- You can assume that the binary tree will have unique values.
- A classical definition of ancestor nodes: "Any node present in the path from that node to the root node (including the root node)"

### Determine if all the characters in a string are unique (2 Points)
Implement a method with the following signature `bool AreCharactersUnique(string input)` that returns true if all the characters in the string are unique.

### Remove duplicated values from a linked list (3 Points)
Implement a method with the following signature `LinkedList RemoveDuplicatens(LinkedLst list)` that removes all duplicated values from the linked list. The modifications must happen in place (i.e. avoid making a copy of the linked list)

- Use your personal Linked List implementation for this problem

### Remove duplicated values from a string (1 Point)
Implement a method with the following signature `string RemoveDuplicates(string input)` that removes all characters values from the string.

### Shuffle a linked list (3 Points)
Implement a method with the following signature `LinkedList ShuffleLinkedList(LinkedLst list)` that re-arranges the nodes of the linked list in a random order. The modifications must happen in-place (i.e. avoid making a copy of the linked list)

- Use your personal Linked List implementation for this problem

### Implement a Stack and a Queue using an Array (3 Points)
Create a generic  `Stack<T>` and a generic `Queue<T>` class that use an array as internal storage. The stack and queue class need to be able to resize its internal storage when required and should each contain the appropriate basic functionality respectively. 

### Generate all combinations of balanced parentheses (6 Points)
Implement a method `string[] GenerateBalancedParethesesCombinations(int n)` that generates all possible pairs of balanced (i.e. every open parenthesis has a matching closed parenthesis)

##### Examples
```
n=1
["()"]

n=2
["()()","(())"]

n=3
["()()()", "(())()", "()(())", "((()))"]

```

### Create an Acronym Generator (1 Point)
Write a function that will take in a string and return the acronym of that string. Words that cannot go in the acronym: `["a", "for", "an", "and", "of", "or", "the", "to", "with"]`

##### Examples
```
acronym('The Federal Bureau of Investigation') // Returns 'FBI'
acronym('') //Returns null
```

### String Compression (1 Point)
Implement a method to perform basic string compression using counts of repeated characters. For example, aabcccccaaa would become a2b1c5a3. If compressed string isn't smaller than the original, return the original.








