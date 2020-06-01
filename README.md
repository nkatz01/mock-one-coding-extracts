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
	Answer:
	The independency Injection pattern and the abstract factory pattern. In the example, instead of having to specify and create a message renderer and provider every time
	we want to pair them up, we ask delegate the task to the system, which finds the available  templates for both, and instantiates them for us so that
	we are not dependant on the exatct implementation and sub-type of the object, but as long as they impelement the super type
	on which our code depends, we can work with anything that impelements/sub-types them.
	
2. **[20 marks]**  
	The key features of object-oriented programming are encapsulation, inheritance, and message passing. Explain why these features are necessary and how they are manifested in the SOLID principles.
	
	S: Single Resoponsibility which is under encapsulation and says that a class or method etc. should have minimal or sinlge responsibility
	so that those changes to the softwares specification, that would affect what this class or method is doing , should be localized and minimal.
	
	O: Open-closed, which is under inheritance and says that software entities should be open for extension and closed for modification. 
	That is, when building it in the first place, rather than to hard code, things that are arbitrary and maybe easily changed and as a result
	force the code to be changed, one should generalize and abstract concepts as much as possible, for eg by the use of
	class inharitance, interface implementation and method overriding/overloading so as to allowe for users of the code or later changes 
	to the specifications of the system, to reuse the old code only with added subclasses, methods etc. I.e. only by having extended the system
	rather than having to make changes to the old code, which may break things relying on them who wouldn't have needed the new changes.
	
	L: Liskov substitution, which is under message passing and inheritance and says, whenever you're expecting a super, giving it
	a sub-type should also work because very sub-type is also a super. So, for eg, in practice, if the design of the system is such that certain attributes
	of the super do not fit on the sub, and still such a class heirarchy were to be desinged, it would violate this principal because handing that object to a method of its super where
	an attempt is made to reference this property for any purpose, it would throw an error, although it accepted that object in the first place.
	
	I: Interface segregation principle, which is under encapsulation and inheritance and says that if thinking about who may use your code, 
	one should always keep their interfaces as narrow as possible, all methods together accomplishing the minimal purpose of the objects implementing this interface.
	that is, one should not be able to imagine a scenario where one of the methods
	declared in a given interface is totally irrelevant to a certain client's needs, whilst all other are (even though, this specific method fits very well an operation those objects implementing this interface need, in most cases, that is to all other clients)
	If an additional functionality comes to mind, for which some clients may find use, a new interface should be created and the clients who need it, will have their objects also implement the second interface.
	
	D: Dependency inversion principle, as in question 8 and to add, high level classess should not depend on low level classess (existing already, or their details to be known)
	but that both should depend an an abstraction, that is an abstracted common notion that unifies them like in a common ancestor way (and one which we agree is fine to depend on), for eg an interface.
	An egample of applying the II principal is run-time reflection and avoiding using the 'new' keyword.
	
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
