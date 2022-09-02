using System; // one of many libraries. Like Import.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace cSharp Tut. // namespace is like packages in java.

class Program {
	// global
	int number0 = 0;
	static string hello = "Hello";
	
  public static void Main (string[] args) {
		
    Console.WriteLine ("{0}", hello);
		//Console.ReadLine(); // listens for user input.

		// ------------- DATA TYPES ------------------------
		/*
											PRIMATIVEs
			int : 4 bytes
				range: (-2 31) to (2 31 - 1)
			long : 8 bytes
				range: (-2 63) to (2 63 - 1)
			short : 2 bytes
				range: (-2 15) to (2 15 - 1)

			double : 8 bytes
				range: -1.79769313486232e308
							to 1.79769313486232e308
			float : 4 bytes
				range: -3.402823e38
							to 3.42823e38


			char : 2 bytes - a single unicode character.
			string : 2 bytes per character.

			boolean : 1 byte - true / false


		*/
		int someVariable;
		someVariable = 2;

		double d = 1.5;
		double accountBalace = 120.3;
		d = 50.6;

		char c = 'c';
		char dollar = '$';

		string s = "Hello world";
		string welcomeMessage = "Hi and welcome to my home";
		string emptyString = "";
		string oneCharacter = "c";

		bool b = true;
		bool activeBankAccount = false;
		activeBankAccount = b;


		// ---- OPERATORS --------------
		/*
			= : assignment
			+   -   *   /
			== : Are these references the same, not objects.
			Equals() : compares objects.

						LOGICAL
			&& - And || - Or  ! - Not
		*/
		int count = 3;
		count += 2; // 5

		if (count < 10){
			Console.WriteLine("Its below");
		}else{
			Console.WriteLine("Its higher");
		}


		//         SWITCH - 
		int menu = 1;

		switch(menu){
			case 1:
				Console.WriteLine("You selected option 1");
				break;
			case 2:
				Console.WriteLine("You selected option 2");
				break;
			case 3:
			case 4:
				Console.WriteLine("You selected 3 and or 4");
				break;
			default:
				Console.WriteLine("Invalid input");
				break;
		}

		//            LOOPS
		/*

		while(condition){

		}
		
			--------------------

		do{

		}while(condition)

			--------------------

		for(declare; condition; manipulate){

		}

				------------------

		foreach(int i array){

		}

		*/

		//     Object Oriented Programing ----------------------------

		/*
				Encapsulation - hiding and exposing of data to outside classes and code.
					use access modifers and properties.
					public - can be accessed by class in the application.
					protected - can be used within the same class, or any subclass even if they are in another assembly.
					private - only accessed within the same class.
					no modifer - "internal" access privleges. Accessible by any class or subclass in the same assembly, but is invisible to code outside of the assembly.

					property:
						get { return robotType; }
						set { robotType - value; }

				Constructor:
					Must have same name as class.
					No return type or even void.
					Can only be called by using new.


				Inheritance:
					Organize classes into a heirarchy.
					Properties and behaviors from the top of the heirarchy will be present in classes lower in the heirarchy.
					Behaviors inhreited from a parent class can be overridden by a child.
					Inheritance reduces boilerplate code.
					Starts with Parent class. Also called base or super class.
					sealed: prevents a class from being inherited.
					can NOT have multiple inheritance.

					public virtual void Travel() // allows child to alter.
					public override void Travel() // in child class.

				Abstract classes:
					Cannot be instatiated, only inherited.
					MAY contain abstract methods.
					Child classes MUST implement inherited abstarct methods, or
						else be abstract classes too.
					Used when wanted to provide a default behavior.
					for non-public properties or provide backing fields.
					Noun.

				Interfaces:
					used to guarantee that subclasses will provide an implementation for certain behaviors.
					All declared methods MUST be abstarct.
					Properties MUST NOT have backing fields, nor get/set.
					Cannot be instantiated, only inherited.
					A class CAN implement multiple interfaces.
					All methods and properties are implicitly public.
					When you want to guarantee that a certain behavior will be implemented.
					Verbs.
					
			
		*/



		//        COLLECTIONS  --------------------------------

		// Arrays - fixed length, same-type objects.
		/*
				object[] myArr = new object[5];
				object[] myArr = { 1,2,3 };

				Multi-Dimensional:
					int[ , ] table = new int[10,10];


			Lists - variable length array, will resize to fit contents
				List<object> myList = new List<object>();
				myList.Add("Hi");

				foreach(string s in myList){
					Console.WriteLine(s);
				}


			Dictionaries - Key and Value pair. Returns null if value doesnt exist.
				Dictionary<int,String> myDic = new Dictionary<int, String>();
				myDic.Add(1, "Bob");

				// Try Get 
				String output;
				if(contacts.ContainsKey("GR")){
					contacts.TryGetValue("GR", out output);
					if(output != null){
						Console.WriteLint(output)l
					}
				}

		*/

		//        Strings ------------------------------
		/*
			String objects are immutable.
			Reference Variables                    Heap Memory
				String var1                            "Hello"
				String var2   // share memory if assigned the same.

					use String var2 = new String("Hello") to create new memory.

			String methods:
				.isNullOrEmpty
				.Insert(1, "o");
				.StartsWith("first")
				.EndsWith("ot")
				.Substring(2)
				.contains("p")
				.spaceDelimitedString.Split(new char[] { ' ' })
				@ - ignores escape character.
				\t - tabbed line.
				\n - new line.


			StringBuilder class is Mutable alternative to Strings.

		*/

		// EXCEPTIONS ------------------------------
		/*
			default exception prints a stacktrace and crashes app.
			Handled by using try/catch.
			Can throw an error at will.
			ArithmeticException.
			NullReferenceException.
			IndexOutOfRangeException.
			StackOverflowException.

			try{
				int zero = 0;
			}catch(ArhitmaticException e){
				Console.WriteLine(e.StackTrace);
			}catch(StackOverflowException){

			}finally{
				// prints even after an error occurs.
			}

			// throw new Exception();






    */








		
		//Console.ReadLine();
  } // main method / starting point.
	
} //class
