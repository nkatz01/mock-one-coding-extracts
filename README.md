# Mock Test One

This is the first mock test which is solely to get you used to the process.

## BIRKBECK (University of London)

## Software Design and Programming - COIY062H7
## Software and Programming III - BUCI056H6

### Duration - three hours

1. Candidates should attempt **ALL** questions on the paper.
2. The number of marks varies from question to question.
3. You are advised to look through the entire examination paper before getting started, in order to plan your strategy.
4. Simplicity and clarity of expression in your answers is important.
5. You may answer questions using only the `C#` programming language unless specified otherwise.
6. You should avoid the use of mutable state or mutable collections in your solutions whenever possible.

--

1. **[12 marks]**   
	Create a method `ManyTimes` that takes a string (`s`) and an int (`i`) as arguments and returns the string argument duplicated `i` many times. Your code should satisfy the following:

	```
	var m1 = ManyTimes("abc", 3); 
	Assert.AreEquals("abcabcabc", m1,"Your message here");
	var m2 = ManyTimes("123", 2); 
	Assert.AreEquals("123123", m2, "Your message here");
	```
	
	replacing `"Your message here"` with an appropriate message.
	
1. **[8 marks]**  
	Which design pattern is represented in the `Complex` code we saw during the course and is available on the course repository? You should justify your answer.

2. **[20 marks]**  
	The key features of object-oriented programming are encapsulation, inheritance, and message passing. Explain why these features are necessary and how they are manifested in the SOLID principles.

1. **[20 marks]**   
	Refactor the `AlertService` and `AlertDAO` classes from the file `Alert.cs`:
	+ Create a new interface, named IAlertDAO`, that contains the same methods as `AlertDAO`.
	+ `AlertDAO` should implement the `IAlertDAO` interface and overload appropriate methods from `Object`.
	+ `AlertService` should utilise constructor dependency injection for `IAlertDAO`.
	+ The `RaiseAlert` and `GetAlertTime` methods should use the same object that was injected.
	+ Provide appropriate tests to support your answer using `MSUnit`.
	
1. **[25 marks]**
	+ Briefly describe how you would refactor a given class into a Singleton?
	+ Which design pattern would you use to assign additional functionality to an object without sub-classing it? 
	Justify your answer and provide an appropriate example.
	+ The code in the file `Driver.cs` is an implementation of which design pattern? You should justify your answer.
	+ When would you use the Composite design pattern? Provide an appropriate example to illustrate your answer.
	+ What are the main objectives of the Decorator pattern? Provide an example to illustrate your answer. Can another design pattern we have studied provide a similar result?
	
1. **[25 marks]**   
	+ Write a program that traverses a collection of names (strings) and returns the first name whose sum of characters is equal to, or larger than, a given number `N`, which will be provided on the first input line. 
	+ Use a function that accepts another function as one of its parameters. 
	Start off by building a regular function to hold the basic logic of the program. 
	Something along the lines of `Func<string, int, bool>`.   
	+ Then create your main function which should accept the first function as one of its parameters to the program.
	
	```
	500
	Fred Maxim Zad Matthew Mary
	Result: Maxim
	```
