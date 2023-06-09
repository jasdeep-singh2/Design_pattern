﻿Definition: In object-oriented programming, the open/closed principle states that "software entities such as classes,
			modules, functions, etc. should be open for extension, but closed for modification"

	1. Which means, any new functionality should be implemented by adding new classes, attributes and methods, instead of changing the current ones or existing ones.

	2. Bertrand Meyer is generally credited for having originated the term open/closed principle and This Principle is considered by 
	   Bob Martin as “the most important principle of object-oriented design”.
 
Implementation guidelines
	1. The simplest way to apply OCP is to implement the new functionality on new derived (sub) classes that inherit the original class implementation.

	2. Another way is to allow client  to access the original class with an abstract interface, 

	3. So, at any given point of time when there is a requirement change instead of touching the existing functionality it’s always 
	   suggested to create new classes and leave the original implementation untouched. Pit falls of Not following OCP
 
What if I do not follow Open closed principle during a requirement enhancement in the development process. 
 
	In that case, we end up with the following disadvantages
 
	1. If a class or a function always allows the addition of new logic, as a developer we end up testing the entire functionality along with the requirement.
 
	2. Also, as a developer we need to ensure to communicate the scope of the changes to the Quality Assurance team in advance so that they 
	  can gear up for enhanced regression testing along with the feature testing. 