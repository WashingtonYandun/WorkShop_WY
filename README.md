# Design Patterns in DotNet

This project is a simple example of the use of some design patterns in C#.

## Creational Patterns

### Singleton

The path to the Singleton pattern is [here](DesignPatterns/Infraestructure/Singleton/Singleton.cs)

The Singleton pattern is a creational pattern that ensures a class has only one instance and provides a global point of access to that instance. It is useful when exactly one object is needed to coordinate actions across the system.
I used the `Lazy<T>` class to ensure that the instance is created only when it is needed.

-   The Singleton pattern is used to store an array of `Vehicles`

### Builder

The path to the Builder pattern files is [here](DesignPatterns/ModelBuilder)

The Builder pattern is a creational pattern that allows constructing complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

-   The Builder pattern is used to create some types of `Vehicles` such as `Mustag, Explorer, etc` objects.

### Factory Method

The path to the Factory Method pattern files is [here](DesignPatterns/Infraestructure/FactoryMethod)

The Factory Method pattern is a creational pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

-   The Factory Method pattern is used to create `Vehicles` objects.

## Usage

To run the application, you can use the following commands:

```bash
dotnet run
```
