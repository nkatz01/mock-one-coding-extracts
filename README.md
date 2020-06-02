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
	The interpreter patter, which provides a wasy to evaluate a language grammar or expression given a formalisation of the rules of that grammer/expression sructure and a way to interpret them.
	This is the case as in this example a sturct is provided foreach symbol (terminal or nonterminal) in the language and the signiture of the methods that interpret them are declared in an interface. The interpretation logic is 
	then implemented, in a composit-pattern fashion, in the struct implementing that interface.
	
	

	
2. **[20 marks]**  
	The key features of object-oriented programming are encapsulation, inheritance, and message passing. Explain why these features are necessary and how they are manifested in the SOLID principles.
	
	S: Single Responsibility which is under encapsulation and says that a class or method etc. should have minimal or single responsibility
	so that those changes to the software specification, that would affect what this class or method is doing , should be localized and minimal.
	
	O: Open-closed, which is under inheritance and says that software entities should be open for extension and closed for modification. 
	That is, when building it in the first place, rather than to hard code, things that are arbitrary and maybe easily changed and as a result
	force the code to be changed, one should generalize and abstract concepts as much as possible, for eg by the use of
	class inheritance, interface implementation and method overriding/overloading so as to allow for users of the code or later changes 
	to the specifications of the system, to reuse the old code only with added subclasses, methods etc. I.e. only by having extended the system
	rather than having to make changes to the old code, which may break things relying on them who wouldn't have needed the new changes.
	
	L: Liskov substitution, which is under message passing and inheritance and says, whenever you're expecting a super, giving it
	a sub-type should also work because very sub-type is also a super. So, for eg, in practice, if the design of the system is such that certain attributes
	of the super do not fit on the sub, and still such a class hierarchy were to be designed, it would violate this principal because handing that object to a method of its super where
	an attempt is made to reference this property for any purpose, it would throw an error, although it accepted that object in the first place.
	
	I: Interface segregation principle, which is under encapsulation and inheritance and says that if thinking about who may use your code, 
	one should always keep their interfaces as narrow as possible, all methods together accomplishing the minimal purpose of the objects implementing this interface.
	that is, one should not be able to imagine a scenario where one of the methods
	declared in a given interface is totally irrelevant to a certain client's needs, whilst all other are (even though, this specific method fits very well an operation those objects implementing this interface need, in most cases, that is to all other clients)
	If an additional functionality comes to mind, for which some clients may find use, a new interface should be created and the clients who need it, will have their objects also implement the second interface.
	
	D: Dependency inversion principle, under reuse and encapsulation and inheritance says that high level entities should not depend on low level entities (having to have been instantiated already, or their details to be known at design or compile time)
	but that both should depend an an abstraction, that is an abstracted common notion (and one which we agree that is so essential and  is therefore fine to depend on), that applies to them both  and identifies both of them so to say  for eg an interface.
	DI helps create loosely coupled code that is it reduces tight coupling between software components by injecting the dependencies among entities at run-time .
	An example of applying the II principal is run-time reflection and avoiding using the 'new' keyword. 
	
	In the example, what we looked at during the course, instead of every time when we want to pair up a message renderer with provider	should our combiner or factory 
	having to be dependent on what sub type of message renderer or message provider it is and whether the objects have already been created or not, we delegate the task of specifying and creating one, to the run-time or -- at run-time to entities 
	whose role is just that --  who find the available templates for both, and instantiates them for us, based on a super type (interface/s) they all share which we know at compile time, so that
	we are not dependent on the exact implementation and sub-type of the object at design or at compile time (and also our client have the flexibility of extending and adding sub-types) but so long as they implement the super type
	on which our code depends, we can work with anything that implements/sub-types them.

	
1. **[20 marks]**   
	Refactor the `AlertService` and `AlertDAO` classes from the file `Alert.cs`:
	+ Create a new interface, named IAlertDAO`, that contains the same methods as `AlertDAO`.
	+ `AlertDAO` should implement the `IAlertDAO` interface and overload appropriate methods from `Object`.
	+ `AlertService` should utilise constructor dependency injection for `IAlertDAO`.
	+ The `RaiseAlert` and `GetAlertTime` methods should use the same object that was injected.
	+ Provide appropriate tests to support your answer using `MSUnit`.
	
1. **[25 marks]**
	+ Briefly describe how you would refactor a given class into a Singleton?
	I would declare a private static object attribute in the class of the class' type, declare the  constructor private and have a static method that when called, would check if that static object
	if it's null and if not just return it; else it would instanciate that static object using the private constructor and return it after. In addition I would add additinal security
	to protect agains breaking the singleton, by means of cloning, reflection or serialization .
 	
	+ Which design pattern would you use to assign additional functionality to an object without sub-classing it? 
	Justify your answer and provide an appropriate example.
	
	Answer: 
	I would use the decorator pattern. The idea is that as well as having simple components that subclass an abstract class let’s say named, Component, we also have Decorators which also 
	subclass Component and take a component upon construction which gets stored in the decorator, so that any additional functionalities are declared within the Decorators who in turn
	execute the operations on the component they have stored. Notice, that these components can either be simple components, or wrapped components themselves, that is, decorators which 
	contain other decorators or simple components; so that every time we want to add an additional functionality, all we need is declare another Decorator that has a method/s with the 
	same signature as method/s declared in the Component abstract class, that desired additional functionality and then wrap the object which we desire to exhibit this functionality, into this
	decorator so that the operations declared in the decorator are invoked on the wrapper, giving the illusion that the object itself supports that operation, and so recursively until the first simple object is finally unwrapped.

	+ The code in the file `Driver.cs` is an implementation of which design pattern? You should justify your answer.
	It is an implementation of the strategy pattern which says that if you have a class that does something specific, in our case travelling, in many different ways, you extract all of these algorithms
	in separate classess called strategies, in our case the different modes of travel, and rename the original class to context, in our case Transportation, 
	that has a field for storing one of the strategies, working with all strategies (only) through the same generic interface, and delegating the work to a linked strategy instead of executing it on its own. 
 	
	
	+ When would you use the Composite design pattern? Provide an appropriate example to illustrate your answer.
	I would use the composite pattern in a case where the same operations are applicable to both an individual object and a wrapper that holds/contains/represents a number of the former but when invoked on
	a wrapper object, it would query its sub objects recursively, until we reach the root where no more unwarapping can be doen and then return the results of all the sub-queries, including its own, to up the tree to its first caller.
	As an example: 
	
	A tree, in particular a palm tree, has a method, count number of leaves (leaves being the actual twigs)
	Each twig has a method, count the number of leaves (leaves being the frond )
	Each frond has a method, count the number of leaves (leaves being the frond's own leaves)
	If we desired an operation that tells out the eventual number of frond leaves, it would then be wise, for the sake of this operation, not to treat being given a tree differently 
	then being given a twig or an individual frond. In this case, we could have an interface that declares a method count leaves, which all 3 implement and the client, needn't know 
	whether the object it is given is a simple component or a complex component since the objects themselves will have the count operation implemented differently depending on which of the
	two they are; so that in effect, the client, when given a tree or a or a twig, invoking the count operation will query first its sub components for how many leaves they have and then multiplies them by how many they themselves have whereas when given a frond
	on its own it  will just give the client straight away the number of its leaves knowing that it doesn't hold any further sub components. And so on for a collection of trees etc.

	
	
	+ What are the main objectives of the Decorator pattern? Provide an example to illustrate your answer. Can another design pattern we have studied provide a similar result?
	Answer: 
	As in point 2 of this question and in addition, the main objective is to avoid the proliferation of (levels of) subclasses and to add additional behavior to an individual object without
	whilst we execute the code without	affecting other objects of the same class which would have been the case if we needed to change the template of the simple components and their
	sub-classes every time we needed to add functionality. It also adheres to the principal of assigning minimal responsibility to each class so to keep the associations between them loosely coupled as discussed above.
	
	eg: 
	
	public abstract class Component{
	
		public abstract void Operation(); 
	}
	
	public class SimpleComponent : Component{
		public override void  Operation(){...}
	}
	
	public  abstract class Decorator : Component{
	
	private Component component {get; set}

	 public  Decorator(Component component){
		
		this.component= component;
	}
	
	public void Operation{
	
	if(component!= null)
		component.Operation(); 
		
	
	}
	}
	
	public class ConcreteDecorator(){
	
	public ConcreteDecorator(Component component) : base(component){}
		
		public void MyOperation() {
		 //possibility for doing some additional functionality here
			base.Operation();
		 //possibility for doing some additional functionality here
		}
	}
	
	main(){
	
	SimpleComponent sc = new SimpleComponent(); 
	ConcreteDecorator cdLevel1 = new ConcreteDecorator(sc); 
	ConcreteDecorator cdLevel2 = new ConcreteDecorator(cdLevel2); 
	cdLevel2.Operation(); //Calls 3 different Operation methods all with the name Operation, reversibly, unwrapping the objects.
	
	}
	
	
	Another, pattern which is similar to the decorator is the chain-of-responsibility pattern, where objects in the chain, either carry out the task themselves, if they can, 
	or move the request along the chain, with the difference being that in the decorator, as shown above, all classes/wrappers are involved in handing the request as the objects are being 
	unwrapped recursively whereas in the chain-of-responsibility pattern.

	
1. **[25 marks]**   
	+ Write a program that traverses a collection of names (strings) and returns the first name whose sum of characters is equal to,
	or larger than, a given number `N`, which will be provided on the first input line. 
	+ Use a function that accepts another function as one of its parameters. 
	Start off by building a regular function to hold the basic logic of the program. 
	Something along the lines of `Func<string, int, bool>`.   
	+ Then create your main function which should accept the first function as one of its parameters to the program.
	
	```
	500
	Fred Maxim Zad Matthew Mary
	Result: Maxim
	```
