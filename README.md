# Arrays

* Array is a continuous space of memory.
So usually you have to tell the compiler how to interpret it.
In other words it's just memory and you have to tell to the computer what it is.

* In JavaScript you can have an ArrayBuffer that you can later mold into different things.

* You can then tell that this ArrayBuffer should be viewed as 1 byte array. And then also view the same array as a 2byte array.

* It's a good example to think about because of how memory works. In a six byte array we can place six 1 byte integers or 3 two byte integers.

* So arrays are fixed size and if you want to grow it you probably need to create a new array and write all the elements of your old array there.

# Binary Search

An important quetion to ask when searching is whether your dataset is ordered.
If the data set is ordered you have new options that might be supah fast.

logN is the binary search. We half our sample logN amount of times to arrive at a value we're looking for. So time complexity is O(logN)/

If you're always divding it is O(logN).
If you also need to scan the input it's O(NlogN).

# Two Crystall Ball Problem

Given two crstal balls that will breadk id dropped from high enough distance,
determine the exact spot in which it will break in the most optimized way.

At this point we know Linear and Binary searching.

Think of it as an array of falses which at some point becomes true and continues to be true.

[FFFFFFFTTTTTT]

We are interested in this switch point.

We can use the linear search and walk it but that doesn't take into account our constraint that we have two crystal balls.

What we could do is drop the crystal point from the middle. Observe if it fails or not and then walk in the direction
of state change. But that is also O(N) we just walk a smaller distance but constants don't count.

The answer is to walk in square roots of N. It's a fundamentally different jump and in worst case if jump by 
square root of N and have to walk back the full square root of N the running time is O(N^2 + N^2) or just O(N^2) if 
we drop constants.

It's a solution to a search problem without doing a linear search.




