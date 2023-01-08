# Arrays

## Utility Tool

> ArrayUtils.java

One-dimensional class framework for array methods to manage them and output them formatted in the terminal.

### Class Functionality

- Reverse element order
- Append element at the end
- Insert element arbitrarily
- Automated dummy returns

### Array Formatting

- Using StringBuilder for performant string assembly
- Places characters before and after elements
- Each array element goes through full loop

### Terminal Output

```
[       1,        2,        3,        4,        5,        6,        7,        8]
[       8,        7,        6,        5,        4,        3,        2,        1]
[       8,        7,        6,        5,        4,        3,        2,        1,        9]
[       8,        7,        6,        5,       17,        4,        3,        2,        1,        9]
[       8,        7,        6,        5,       17,        4,        3,        2,        1,       23,        9]
[       8,        7,        6,        5,       17,        4,        3,        2,        1,       23,        9,       27]
End of regular Expression
```

# Matrix

## Utility Tool

> Matrix.java

Two-dimensional class framework for matrix methods to generate empty matrices in given sizes.

### Class Functionality

- Uses one-dimensional array of values
- Distributes this for each matrix row
- Form row sum
- Create row sum
- Transpose matrix

### Matrix Formatting

- Formatting as string
- StringBuilder for performant assembly
- Places characters before and after elements
- Each array element goes through full loop

### Terminal Output

```
┌       2,        4,        6,        8┐
│       1,        2,        3,        4│
└       1,        2,        4,        8┘

[       4,        8,       13,       20]
[      20,       10,       15]

transposed:

┌       2,        1,        1┐
│       4,        2,        2│
│       6,        3,        4│
└       8,        4,        8┘

[      20,       10,       15]
[       4,        8,       13,       20]
┌       1,        2,        3,        4,        5,        6,        7,        8,        9,       10,       11┐
│      28,       29,       30,       31,       32,       33,       34,       35,       36,       37,       12│
│      27,       48,       49,       50,       51,       52,       53,       54,       55,       38,       13│
│      26,       47,       46,       45,       44,       43,       42,       41,       40,       39,       14│
└      25,       24,       23,       22,       21,       20,       19,       18,       17,       16,       15┘

true
```

## Snail Builder

> Schnecke.java

Suitable custom implementation to fill a matrix of any size starting from the upper left corner with ascending numbers starting from 1 in a spiral fashion.

![Matrix Snail Algorightm](/img/practical_1.png)

### Terminal Output

```
┌       1,        2,        3,        4,        5┐
│      14,       15,       16,       17,        6│
│      13,       20,       19,       18,        7│
└      12,       11,       10,        9,        8┘
```

## Semimagic Square

> Semimagic_Square.java

The Application is able to check if the matrix as a semimagic square. A semimagic square of edge length n is a square arrangement of the natural numbers so that the sum of the numbers of all rows and columns is equal.

### Terminal Output

```
┌      16,        3,        2,       13┐
│       5,       10,       11,        8│
│       9,        6,        7,       12│
└       4,       15,       14,        1┘

It is a semimagic square matrix.
```
