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
	
		
		//Console.ReadLine();
  } // main method / starting point.
	
} //class
