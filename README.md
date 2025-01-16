# Uninitialized Property Access in C#

This example demonstrates a common issue in C# where a property is accessed before it's been explicitly assigned a value.  This can lead to unexpected behavior and hard-to-debug problems, especially in larger projects.

## The Bug

The `MyClass` demonstrates the problem. The `MyMethod` attempts to print the value of `MyProperty` before a value is assigned to it.  While this will compile and run, it may not produce the expected result. In the case of numerical types, the property's default value (0 for `int`) will be printed.  However, in more complex situations, the behavior might be less obvious. 

## The Solution

The solution file shows how to initialize the property either in the class declaration or before accessing it in the method.  Always ensure your properties are initialized before use to avoid such issues.