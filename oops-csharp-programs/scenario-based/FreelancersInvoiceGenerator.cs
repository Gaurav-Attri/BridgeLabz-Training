using System;
class FreelancersInvoiceGenerator{
	private string invoiceDescription;
	private int taskCount;
	private string[] tasks;
	private double[] amounts;
	private double totalAmount;

	static void Main(string[] args){
		FreelancersInvoiceGenerator freelancersInvoiceGenerator = new FreelancersInvoiceGenerator();
		freelancersInvoiceGenerator.StartApplication();
	}

	private void StartApplication(){
		Console.WriteLine("\n=============== FREELANCERS INVOICE GENERATOR ===============\n");
		Console.Write("Please enter invoice description (like task 1 - 3000 INR, task 2 - 5000 INR): ");
		this.invoiceDescription = Console.ReadLine();
		
		CountTasks();
		tasks = new string[this.taskCount];
		amounts = new double[this.taskCount];
		ParseInvoice();
		GetTotalAmount();
		GenerateInvoice();
		
	}

	private void GenerateInvoice(){
		Console.WriteLine("\n==================== INVOICE ====================\n");
		for(int i = 0; i < taskCount; i++){
			Console.WriteLine(tasks[i] + "\t\t " + amounts[i] + " INR");
		}
		Console.WriteLine("\nTotal amount to be paid: " + this.totalAmount + " INR");
	}

	private void GetTotalAmount(){
		for(int i = 0; i < taskCount; i++){
			this.totalAmount += amounts[i];
		}
	}

	private void ParseInvoice(){
		string[] taskAmountPairs = this.invoiceDescription.Split(',');
		int index = 0;
		for(int i = 0; i < taskCount; i++){
			string[] taskAmountPair = taskAmountPairs[i].Split('-');
			this.tasks[index] = taskAmountPair[0].Trim();
			this.amounts[index] = double.Parse(taskAmountPair[1].Trim().Split(' ')[0]);
			index++;
		}
	}

	private void CountTasks(){
		int countTasks = 0;
		foreach (char c in invoiceDescription){
			if(c == ','){
				countTasks++;
			}
		}
		this.taskCount = countTasks + 1;
	}
}
