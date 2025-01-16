public class MyClass
{
    // Initialize the property in the class declaration.
    public int MyProperty { get; set; } = 0; //or any default value 

    public void MyMethod()
    {
        // Accessing the property after initialization.
        Console.WriteLine(MyProperty); 
    }
}