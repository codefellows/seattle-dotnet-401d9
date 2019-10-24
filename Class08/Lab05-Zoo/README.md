# Lab 5/6 Zoo

*Author: Darrik Puetz*

----

## Description

A zoo contains animals, and animals can come in many different shapes and sizes. It is your job to plan and build out what animals that live in the zoo.
Using UML, diagram what animals the zoo will consist of. Include in each class the properties and behaviors for each animal, as well as the relationships between each animal from it’s base classes. This zoo has the ability to create new animals to put into the zoo based upon what the user inputs as choices.

## What is OOP?
### Four Pillars
1. Abstraction
    - Used to share info in between classes
	- Classes can not be used to create instances
	- Can contain abstract methods
	- Methods need to be called in the parent and overridden in the children
2. Encapsulation
    - You want to put something into a container. i.e.(functions, classes, and folders)
3. Polymorphism
    - It remembers it's top level even though it was turned into things from that. (vehicle ---> 4 wheel---> car)
4. Inheritence
    - Basic method to extend types based on the other types.
### Five Principles
1. Single Responsibility Principle
    - Only having one reason to change as a class.
2. Open Closed Principle
    - Open to Extension and closed to modification.
    - Applying to my classes only certain abstact methods to be used within children.
3. Liskov Substitution Principle
    - Writing code cleanly so other developers can use the same class to build off of.
4. Interface Segregation Principle
    - Having the ability to use others. Default interfaces are public and abstract.
    - void DrawScreen(IDrawable[]:terms)
    - Be specific.
5. Dependency Inversion Principle
    - Building your code to be able to use abstract methods to work with.
    - Using my abstract methods within other classes to change the function. 

### Interfaces
An interface is the ability to use a method in a specific class. It is the solution to using methods without specifically using abstract inheritance.
My interfaces are IDestroy and an IHibernate. Both run methods that are defined in the classes that I choose being the MeatEaters class and the Diplosaurus.


### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/darrikpuetz/Lab05-Zoo.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Lab 05 Zoo```

Next navigate to the location you cloned the Repository.

Double click on the ```Lab 05 Zoo``` directory.

Then select and open ```Lab 05 Zoo`.sln```

---


### Visuals
## UML

![UML](https://github.com/darrikpuetz/Lab05-Zoo/blob/master/assets/Lab-05-Zoo-Diagram%20(1).png)




#### Using the Application
![Using](https://github.com/darrikpuetz/Lab05-Zoo/blob/master/assets/Using.PNG)

---

### Change Log
1.1: Finished the original version with dll error in testing 22 OCT 2019  

### Credit 
1. [System I.O.] https://docs.microsoft.com/en-us/dotnet/standard/io/index
2. [Stream Writer] https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netframework-4.8
3. [Stream Reader] https://docs.microsoft.com/en-us/dotnet/api/system.io.stringreader?view=netframework-4.8
4. [Using Stream] https://introprogramming.info/english-intro-csharp-book/read-online/chapter-15-text-files/




------------------------------
For more information on Markdown: https://www.markdownguide.org/cheat-sheet
