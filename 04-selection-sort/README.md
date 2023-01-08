# Selection Sort

> `./Assets/Scripts/SelectionSort.cs`

## Description

> This subfolder is a independent Unity project which can be built and exported.

Program to generate and sort numbered 2D nodes based on the selection sort algorithm. The slowed algorithm will run through nodes visually and show each step as commentary before handing out the final result.

## Architecture

Selection sort is n in-place comparison sorting algorithm. It operates by splitting the node list into two sublists: the sublist of things that have already been sorted, which fills the front of the list and the sublist of items that still need to be sorted. The default node list is the complete unsorted sublist at first, while the sorted sublist is initially empty. The algorithm then moves the sublist borders one element to the right after finding the smallest element in the unsorted sublist, trading it with the next-to-left unsorted element to sort the unsorted sublist. This algorithm loops through until the full node list is sorted correctly.

## Features

- Creation of visual 2D nodes
- Adding or removing nodes
- Visual feedback for the sort algorithm
- Text description for step commentary

## Showcase

![Practical 4 Screenshot 1](../img/practical_4_01.png)
![Practical 4 Screenshot 2](../img/practical_4_02.png)
![Practical 4 Screenshot 3](../img/practical_4_03.png)
