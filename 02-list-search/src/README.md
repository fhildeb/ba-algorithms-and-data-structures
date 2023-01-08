# Lists

## Double Linked List

> DoubleLinkedList.java

Entity Class of a double-linked list through interface and list node where each element of the list points to predecessor and successor. The list ends can the be be recognized automatically by the missing reference.

![Double Linked List](/img/practical_2.png)

### Architecture

- List header stores the references to the list ends
- Interface for data element with last and previous entity link
- Iterable Interface for the use of loops for testing and outputs
- Generic types for all elements

### Features

- Generate empty link list
- Adding nodes at front and back
- Removing nodes from front and back

# Search

## Search Algorithm Speedtest

> Main.java

Framework and Tester to collectively store sets of algorithms and measure their performance of each other against them.

### Default Algorithms

- Naive search
- Binary search

### Terminal Output

```
3rd Array Test
Naive Search:
Search.WithCount@49476842
Binary Search:
Search.WithCount@78308db1
-

6th Array Test
Naive Search:
Search.WithCount@27c170f0
Binary Search:
Search.WithCount@5451c3a8
-
```
