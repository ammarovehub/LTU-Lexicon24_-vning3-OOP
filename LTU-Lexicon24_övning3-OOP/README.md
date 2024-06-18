C# Exercise Collection - Encapsulation, Inheritance, and Polymorphism
Throughout the tasks, there are some knowledge questions (starting with "F:"). These questions should be answered as comments in the code. The code does not need to take input from a user.

3.1) Encapsulation
Create a class Person and give it the following private fields: age, fName, lName, height, weight Create public properties with get and set that fetch or assign the variable. Instantiate a person in Program.cs, can you access the variables directly? Implement validation in the created properties:
Age can only be assigned a value greater than 0.
FName is mandatory and must not be less than 2 characters or more than 10 characters.
LName is mandatory and must not be less than 3 characters or more than 15 characters. Throw an exception of type ArgumentException in each property if its validation is not completed, the exception should contain a descriptive message. Make sure to handle exceptions in Program class with a try-catch block.

To further encapsulate Person objects we will create the class PersonHandler - a class whose purpose is to create and manage your Person objects. In PersonHandler class create method:

public void SetAge(Person pers, int age)
Use the sent person's Age property to set the person's age attribute via SetAge method. Instead of just using a property we have now abstracted two layers.

In PersonHandler, write a method that creates a person with given values:
public Person CreatePerson(int age, string fname,
string lname, double height, double weight)
Continue creating methods in PersonHandler to be able to handle all operations one might want to do with a Person.

When this class is complete, comment out your previous instance of Person from Program.cs, and instead instantiate a PersonHandler. Create some people and test your methods.

3.2) Polymorphism
Create the abstract class UserError
Create the abstract method UEMessage() that has return type string.
Create a regular class NumericInputError that inherits from UserError
Write an override for UEMessage() so that it returns "You tried to use a numeric input in a text only field. This fired an error!"
Create a regular class TextInputError that inherits from UserError
Write an override for UEMessage() so that it returns "You tried to use a text input in a numeric only field. This fired an error!"
In Program.cs Main method: Create a list with UserErrors and populate it with instances of NumericInputError and TextInputError.
Print all UserErrors UEMessage() through a foreach loop.
Now create three own classes with three own definitions on UEMessage()
Test and see that it works.

3.3) Inheritance
Create abstract class Animal
Fill the Animal class with properties that all animals should have. For example, name, weight, age.
Create an abstract method called DoSound().
Add a constructor.
Create Subclasses (inherits from Animal): Horse, Dog, Hedgehog, Worm and Bird, Wolf.
Give these at least one unique property each. Which property it is is not important here. Example Worm: IsPoisonous, Hedgehog: NrOfSpikes, Bird: WingSpan etc.
Implement so that DoSound() method prints out how the animal sounds.
Now create the following three classes: Pelican, Flamingo and Swan. These should inherit from Bird.
Give these at least one unique property each.
Create the interface IPerson with a method declaration Talk().
Create the class Wolfman that inherits from Wolf and implements IPerson interface.
Implement Talk() that prints out what Wolfman says.
F: If we during development come to the conclusion that all birds need a new attribute, in which class should we put it?
F: If all animals need the new attribute, where should we put it then?

3.4) More polymorphism
Create the method Stats() in the Animal class that has return type string. The method should be able to be overridden in its Subclasses. The method should return all properties that the animal has.
Write an override for Stats() in the subclasses for Animal so it returns all properties for that animal.
Create a list Animals in Program.cs that receives animals.
Create some animals (of different type) in your list.
Print out which animals are in the list with the help of a foreach loop
Also call Animals Sound() method in the foreach loop.
Make a check in the for loop if an animal is also of type IPerson, if it is type-cast to IPerson and call its Talk() method.
Create a list for dogs.
F: Try to add a horse to the list of dogs. Why does not it work?
F: What type must the list be for all classes to be stored together?
Print all Animals Stats() through a foreach loop.
Test and see that it works.
F: Explain what is happening.
Print Stats() method only for all dogs through a foreach on Animals.
Create a new method with any name in the Dog class that only returns a random string.
Can you access that method from Animals list?
F: Why not?
Find a way to print out your new method for dog through a foreach on Animals. Good luck!