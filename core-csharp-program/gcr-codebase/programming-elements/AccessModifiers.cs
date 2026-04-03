using System;
class AccessModifiers{
	static void Main(String[] args){
		DemoClass obj = new DemoClass();
		/* PRIVATE ACCESS MODIFIER DEMO
		 * If we uncomment the below line, it will throw an error as we're trying to access a private field
		 * which is illegal (not allowed) in C#
		 */
		// Console.WriteLine(obj.DemoClassPrivateField);
		

		/*
		 * But we can access a private member using a getter method like demonstrated in the below line.
		 * The below line works fine.
		 */
		obj.PrivateFieldGetter();

		/* PROTECTED ACCESS MODIFIER DEMO
		 * Just like Private Fields, Protected fields also can't be accessed outside the class.
		 * But, they can be accessed in a child class. Which is demonstrated by the "DemoChildClass" 
		 * So if you uncomment the below line, it will throw an error.
		 */
		// Console.WriteLine(obj.DemoClassProtectedField);
		
		/*
		 * Here, DemoChildClass is a child class of DemoClass. Hence, we are able to access protected members
		 * of DemoClass inside the DemoChildClass.
		 */
		DemoChildClass childObj = new DemoChildClass();
		childObj.PrintDemoProtected();


		/* PUBLIC ACCESS MODIFIER DEMO
		 * Below line works fine as public fields can be access anywhere
		 */
		Console.WriteLine("DemoClassPublicField: " + obj.DemoClassPublicField);

		/*
		 * INTERNAL ACCESS MODIFIER
		 * Internal access modifier restricts the entities to be visible/accessible within the same project
		 * only
		 */

		/* PROTECTED INTERNAL MODIFIER
		 * This modifier allows access to entities from any class within the same project or from derived
		 * class in other projects.
		 */

		/* PRIVATE PROTECTED MODIFIER
		 * This modifier limits the accessibility of entities to the containing class itself and to the
		 * children classes but ONLY within the same project.
		 */
	}
}


// Creating a dummy class to demonstrate the use of access modifers
class DemoClass{
	private int DemoClassPrivateField = 20;
	protected int DemoClassProtectedField = 30;
	public int DemoClassPublicField = 40;
	internal int DemoClassInternalField = 50;
	protected internal int DemoClassProtectedInternalField = 60;

	public void PrivateFieldGetter(){
		// We can access the private field here
		Console.WriteLine("DemoClassPrivateField: " + DemoClassPrivateField);
	}
}

// Inheriting the DemoClass
class DemoChildClass : DemoClass{
	public void PrintDemoProtected(){
		Console.WriteLine("DemoClassProtectedField: " + DemoClassProtectedField);
	}
}


