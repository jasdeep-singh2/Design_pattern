
As per the single responsibility principle 
	1. A class should have only one reason to change
	2. Which means, every module or class should have responsibility over a single part of the functionality provided by the software,
	   and that responsibility should be entirely encapsulated by the class.

In Single Responsibility Principle 
	1. Each class and module should focus on a single task at a time
	2. Everything in the class should be related to that single purpose
	3. There can be many members in the class as long as they related to the single responsibility
	4. With SRP, classes become smaller and cleaner
	5. Code is less fragile 

Motivation behind using single responsibility principle

	Maintainability : Maintainable systems are very important to the organisations.

	Testability : Test driven development (TDD) is required when we design and develop large scale systems

	Flexibility and Extensibility : Flexibility and extensibility is a very much desirable factor of enterprise applications.
	Hence we should design the application to make it flexible so that it can be adapt to work in different ways and extensible so that we can add new features easily. 

	Parallel Development : It is one of the key features in the application development as it is not practical to have the entire 
	development team working simultaneously on the same feature or component. 

	Loose Coupling : We can address many of the requirements listed above by ensuring that our design results 
	in an application that loosely couples many parts that makes up the application.