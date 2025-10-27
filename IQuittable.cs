using System;

namespace InterfaceExample
{
    // Define an interface named IQuittable.
    // Interfaces only define a contract (a list of methods or properties a class must implement).
    public interface IQuittable
    {
        // This method must be implemented by any class that inherits from IQuittable.
        void Quit();
    }
}
