using System;

// Things learnt:
//  - Lists are dynamics whilst Arrays are fixed
//      + Lists are actually built on top of Arrays
//      + Array class has static methods which are useful, such as Sort
//  - You can iterate through an array or list using a For loop using array.Length and array[i] OR a While loop by using a counter
//      + While loop makes no sense when you have a set upper bound and is only useful when dealing with uncertainty
//      + Foreach loop is cleaner when you don't need to do anything with the index, like you can do in a For loop
//  - Value types vs Reference types:
//      + Value type variables contain the assigned value and, when passed to a method, are copied so that the original value is unaffected
//      + Reference types store the address of where the value is being stored/a pointer, so that value can be affected by methods
//      + Reference types can be NULL because it can not point to a memory location, whilst Value types cannot be null because it needs to hold a value
//      + Primitive data types (numbers, char and bool) and struct are of the 'Value' type, whilst Class objects, string, array, and delegates are reference types
//      + Value types are stored in the Call Stack, whilst Reference types are stored in the Heap

namespace arrayunscrambler
{
    class Program
    {
        static void main(string[] args)
        {

        }
    }
}
