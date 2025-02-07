# F# Mutable Tuple Swapping Bug

This repository demonstrates a common error when working with mutable tuples in F#.  The issue arises from the fact that tuples, even mutable ones, are passed by value, not by reference.  This means that changes made to the tuple inside a function won't affect the original tuple outside the function's scope.

## Bug Description

The `bug.fs` file shows an example of this behavior.  The `swapTuple` function attempts to swap the values in a mutable tuple, but this is ineffective. The original tuple remains unchanged after the function call. This is because a copy of the tuple is passed into the function, instead of a reference, even though `tuple` is mutable.

## Solution

The `bugSolution.fs` file demonstrates a correct approach to swapping values in a mutable tuple, that is by returning the new tuple.
