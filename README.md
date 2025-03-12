# Data Structures

## Arrays

* Array is a continuous space of memory.
So usually you have to tell the compiler how to interpret it.
In other words it's just memory and you have to tell to the computer what it is.

* In JavaScript you can have an ArrayBuffer that you can later mold into different things.

* You can then tell that this ArrayBuffer should be viewed as 1 byte array. And then also view the same array as a 2byte array.

* It's a good example to think about because of how memory works. In a six byte array we can place six 1 byte integers or 3 two byte integers.

* So arrays are fixed size and if you want to grow it you probably need to create a new array and write all the elements of your old array there.

## Linked List

Just a reminded a true array CANNOT grow!
And it's not the only thing that sucks about an array.
Additionally you can't delete things from it and you cant insert things in it.

Introducing linked lists. They can be singly linked or doubly linked.
Also known as the node based data structure.

Linked list is data organized in a way where a single node can be visited and it also points to the next node.

Something like this:
A > B > C > D...

So now if we want to get the [i] element we need to start from the head element and go through the whole thing to the ith place.

In pseudo code think about it this way:
```
Node<T>
  val: T
  next?: Node<T>
```
So the above is a singly linked list, where you can only walk one way.
A doubly linked list improves the upone the design by allowing to walk backwards.

A <> B <> C <> D...

```
Node<T>
  val: T
  next?: Node<T>
  prev?: Node<T>
```

Inserting is supposedly cheap and fast here cause in order to do it you only need adjust pointers of the new as existing nodes.

These operations cost the same amount of time no matter how big the linked list is.
Setting the next of the previous property costs the same amount of time.

To inesrt into a linked list at a given position is O(1).

And deletion is just the same. We just break some links and repoint them to still existing neighbours.
Ordering of operations is extremely important here, cause you may lose access to your nodes if you're not careful.

The complexity of deletion is also constant.

But if we were to find a value there's no other way than to walk the list.
The time complexity in this case becomes O(n).
From the practical implementation standpoitn, you should not return the node but only the retrieved value.
Returning a node can be dangerouse as then someone can mess with our next and/or previous values.

Getting the head or the tail of the linked list can become a constant operation if we have pointers to them.
In general the deletion and insertion at the head or tail are very fast for the linked list.

## Queue

Our first data structure on top of the linked list is going to be the queue.
It's a very common data structure.

h     t
A>B>C>D

Queue is a fifo structure aka, first in first out.
If we wanted to add another element to our queue we would update D to point to E and then update our tail pointer to point to this new element.

h       t 
A>B>C>D>E

And when we pop, we pop from the head. And note that for the queues we can use a singly linked list.

h     t 
B>C>D>E

Another common operation with queues is "peek" which would return the value of the head element without actually popping it.

## Stack

The second structure based on a linked list a stack. The stack is a FILO structure, that is first in last out. 
The most recent elements included in the stack will be the first ones to exit.

You can think about the queue as Queue in reverse:

A<B<C<D<E

Then when you pop the stack, you simply remove the latest or "last" in our case element.

A<B<C<D

## Array vs Linked List
* Usability
    * Arrays 
Give access by index. Very easy to set and get values.
Easy to understand what is happening on the computer itself.
Simple memory allocation. But you have to allocate it all upfront.
One of the problems is that you don't have inserts. You have to do additional work to shift the array.
Time complexity is easy to understand as well.

    * Linked List
Only uses the memory it needs - memory becomes dynamically managed.
You can optimes a linked list to reuse nodes - there are ways to speed things up.
Here you can't get just the value by key, you must always traverse.
It's always a linear search. You can't just hop into the middle.
So not great for random access but very nice for pushing and popping.

## ArrayList
Can we do better? Can we have an array access with ability to grow?
So this is just a 'List<T>'. I think List in .net has an array as an underlying stucture
and operation to manage it are abstracter from the user.
```
 1   3
[2, , ]
```
Here we have an array that can store three items.
We can track it's current length L which is 1 currently.
And when can also know it's capacity C which is 3 in total.

Knowing these two items we can perform push operations on an array.
```
 1   3
[2,3, ]
```

Since we know the index, the push operation will be contstant time.
It's the same with pop.

What happens with push, when we exceed capacity?
We create a new array with bigger capacity and copy the values.

What about Queue operations? Can we enqueue and deque?
Say we have this data array and want to enque an item.
```
[3,2,1]
```
First we have to grow our capacity:
```
[3,2,1, ]
```
And now we have enough room to enqueue a new item.
But first we need to shift our items to the right. 
```
[ ,3,2,1]
```
Once that is done we can enqueue our new value:
```
[4,3,2,1]
```
This is not very efficient it's O(n). And usually not a way to go about this. 

So this sort thing is good with push and pop but not that great with enqueue.

Similar with deletions and insertions. You would have to shift everything to one
side or the other.

## Ring/Array Buffers
I don't even know what these are.
Okay so in the array list our tail and head are at the start and end of the
array, but in the array buffer head and tail can have their own custom indexes.

```
    h     t
[1, 2, 3, 4, 5]
```
And here to remove an item for our array buffer we would just h+1.
```
       h  t
[1, 2, 3, 4, 5]
```
Same thing with the tail. If you wanted to add something to the tail - just t+1.
```
       h     t 
[1, 2, 3, 4, 5]
```
Pushing and popping here are all O(1) operations.
And you may think that you can go out of bounds with the tail or head.
But this is why it is called a ring buffer, you go around the ends of the array.

It somehow works with doing modulo on the tail: tail % len, gives you the index into the array.
Okay so we take modulo len to ensure that the tail is within bounds. Within len.
This sort of structure could result in tail being before head when imagining a flat array.

The problems begin when your tail EXCEEDS the head. That means you need to resize.
Resizing is tricky. When you try to insert at tail and you notice that the tail is at head, 
you need to go around the ring adding all elements in the new, larger array.

One implementation for it can ge a log batcher?
It's a services that batches logs and writes logs.
Logs need to maintain order and while you're writing logs, new logs have to be able to come in.
Yeah, thats a bit unclear to my how this is good application for ring buffers.

# Algos: search
## Binary Search

An important quetion to ask when searching is whether your dataset is ordered.
If the data set is ordered you have new options that might be supah fast.

logN is the binary search. We half our sample logN amount of times to arrive at a value we're looking for. So time complexity is O(logN)/

If you're always divding it is O(logN).
If you also need to scan the input it's O(NlogN).

## Two Crystall Ball Problem

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

# Algos: sort

If you're learning Algos, at some point you gotta learn sorting.

## BubbleSort

Usually people start of with insertion sort but people say it is boring. And tricky to get.
So here we will start with BubbleSort. It's easy to visual what is happening.
For any sorting algorith the result is a sorted entity. Mathematically we can express it like this:

```
Xi <= Xi+1
```

How bubble sort works is that it changes positions with the Xi+1 if the Xi+1 is lower than X.
On the first iteration the largest item will travel to the end of the array.

This:
```
[1, 3, 7, 4, 2]
```

Turns into this:
```
[1, 3, 4, 2, 7]
```

So the next time we do the bubble sort we can exclude the last position.
That position is already sorted and we don't need to got there.

On the next iteration we get an array like this:

```
[1, 3, 2, 4, 7]
```

We iterate again and we will get this:

```
[1, 2, 3, 4, 7]
```

And we keep going until we have only one element in the array.
And the array of one element is always sorted.

What is the time complexity of this sort?
```
       h  t
[1, 2, 3, 4, 5]
```
Well one fact we can state is that our array decreases by one on each run.
On the first run the number of comparissons we have to do is: (N-1).
On the second run: (N-2).

Which looks very similar to how  Gauss taught us to calculate the summation of consecutive numbers:

1..100 = 101
2..99 = 101
...
50..51 = 101 and by this time we will have added all the pairs together.

And since we had 50 pairs it's 101*50. The abstraction looks like this:
```
(N+1)N/2
```

We get the time complexity of N sq or N^2.
We drop the division /2
We unpack it to N^2 + N.
And then we drop the insignificant + N. Simply because N^2 will be so much bigger than N.
And what we're left with is O(N^2).

## QuickSort

This algo is supposed to be simple. It's simple and brilliant.
This algo uses a technique of "Divide and Conquer"... Apparently this is an amalagamation 
of words used quite often in algos. This basically means that we divide our inputs 
into smaller subsets and then go over them faster.

Think of it like this... An array of one element is always sorted.

0      P N
[        ]
P - pivot (random element)
FR - first runner pointer
S - scanner pointer 

1. In quicksort we pick any element as the pivot element.
2. We use the S scanner pointer to go through an array.
3. We check the element at S.
4. If the element S is less or equal to P, then we put it in FR position and increment it.
5. At this point we have an array wher P hangs out in the middle and things 
lower than P are on the left, while things higher than P are on ther right. This 
is called a weak sort and there are strategies which leverage this sort structure.

0  <  P  <  N
[           ]

6. Now we take the positions between 0 and P, and P and N and we repeat the process. 
Assing new pivots, move items to the sides of the pivots.
7. So you can see now how by making ranges smaller and smaller with each iteration 
we will finally arrive at a situation where range is an array of 1 element. At 
this point we can call it sorted.

It's easier and probabaly more apropriate to image with trees:

                 [0....31]
                    P=16
            [0-15]      [17-31]
              P=8         P=24
        [0-7]  [9-15]  [17-23]  [25-31]

# Recursion

## Basic Example. Maybe easy maybe not so easy.
It's something that keeps on calling itself over and over.
It's a function that calls itself until the problem is resolved.
This usually involves a base case. A base case is the point in which the problem is solved at.
At this point the function no longer calls itself and is able to return a value or do something final.

That's an example of recursion.
This is the sum of all the numbers in a number.
You can solve this with a gausian formula but here we recurse.
```
public static int Foo(int n) {
    // Base Case:
    if (n == 1) {
        return 1;
    }

    // Recurse
    return n + Foo(n - 1);
}
```

To understand recursion it is useful to understand these three things about functions.
Each function usually has:

rA - return address, this is where the function returns its value.
rV - return value, this is the actual value that it is returning.
A - our arguments, input for the function.

Let's walk through our recursive function and understand what happens.

When we initially call foo(5) our return address is something. 
It goes somewhere to the caller. We will mark it liket this <-.
And we don't really know our return value at this moment. 
The only thing we know, is that it is 5+
And our argument is 5. Heres our initial iteration.

```
         rA      rV       A
foo(5)   <-      5+       5
foo(4)
foo(3)
foo(2)
foo(1)
```

Let's walk through code. Is it 1? No.
Then we go the return where we kick off another iteration with foo(4).
Where is foo(4) pointing to? It is pointing to foo(5), we'll mark it as ^.

```
         rA      rV       A
foo(5)   <-      5+       5
foo(4)   ^       4+       4
foo(3)
foo(2)
foo(1)
```

We repeat this process until our base case.


```
         rA      rV       A
foo(5)   <-      5+       5
foo(4)   ^       4+       4
foo(3)   ^       3+       3
foo(2)   ^       2+       2
foo(1)   ^       1        1
```

When our A is 1 we hit the base case. We solved the recursion and we return 1.
This return doesn't have a function call to it self - the recursion is complete.
Now the return values will go back up the chain. Back to each rA of each run until we return to the caller.
It happens in this order:

```
Return order:             rA      rV        A
      g          foo(5)   <-      5+10      5
      4          foo(4)   ^       4+6       4
      3          foo(3)   ^       3+3       3
      2          foo(2)   ^       2+1       2
      1          foo(1)   ^       1         1
```

The last return will pass 15 to the caller.
You can visual recursion well by throwint at base case:

```
Unhandled exception. System.Exception: Exception of type 'System.Exception' was thrown.
   at Foo(Int32 n) in RecursionEx1.cs:line 8
   at Foo(Int32 n) in RecursionEx1.cs:line 10
   at Foo(Int32 n) in RecursionEx1.cs:line 10
   at Foo(Int32 n) in RecursionEx1.cs:line 10
   at Foo(Int32 n) in RecursionEx1.cs:line 10
   at LearningAlgos.Program.Main(String[] args) in Program.cs:line 21
```
Notice how we initially throw at line 8 and then go back throuh return addresses to the original caller,
throwing at each iteration in the stack trace. Notice how line numbers for recursive calls are the same.

So, first we went downwards all the calls and then we went upwards once we hit the base case.
It's improtatnt to understand this pathing, it unlocks some functionality for us.
There are three steps to recursion.

1. pre: this is our n+, a step before we dive into recursion.
2. recurse: the call to itself.
3. post: upwards return. Here when we went upwards we could for example log it steps before returning.
This pathing is important to understand and may unlock some options for your solutions.

To understand the post step better we can illustrate it by modifying our code like this:
```
public static int SubtractUntilOne(int n) {
    // Base Case:
    if (n == 1) {
        Console.WriteLine($"Post step output log: {n}");
        return 1;
    }

    var result = n + SubtractUntilOne(n - 1);
    Console.WriteLine($"Post step output log: {n}");
    return result;
}
```

This will be output the value of n in the upwards direction:
```
Post step output log: 1
Post step output log: 2
Post step output log: 3
Post step output log: 4
Post step output log: 5
```

Recursion is prevalent in tree and graph algorithms.
Regex is just a graph underneath a hood.

## Another Example. Should be easier to understand.

We will be working on a maze solver.

The input is a sting array like this where:
/# - walls
E - ending, where we want to get to
S - start position

```
[
"##########E#",
"#          #",
"# ##########",
"#          #",
"########## #",
"#          #",
"#S##########",
]
```
How are we gonna solve this? You know the anser, it's recursion.
Let's think about this. What can we do at any one square?
1. We can go UP.
2. We can go RIGHT.
3. We can go DOWN.
4. We can go LEFT.

But we can't always do them
1. Sometimes we can bump into walls.
2. We can go off the graph... If in our start position we go doen we're out of 
3. We could also go to a spot we've seen before. But this would be pretty bad 
we could get stuck between squares indefinitely.

All these three are our base case. We don't check for them in our recursive case.
So to rephrase, our base case:
1. Off the map.
2. It's a wall.
3. It's the end.
4. We have seen it.

Recursive step/case:
1. Check every direction, go to every direction in the square.

When to use recursion? 
When it's not solvable via a for loop.
There is no defined end.
There's branching involved.


