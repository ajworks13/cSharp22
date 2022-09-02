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

		*/
		
		
		//Console.ReadLine();
  } // main method / starting point.
	
} //class
