using System;

//class for handling stack/queue ioerations

public class OperationHandler
{
	private string option = "";
	public void PrintAvailableOperations()
	{
		Console.WriteLine("1. push - Push elements");
		Console.WriteLine("2. pop - Pop elements");
		Console.WriteLine("3. peek - View top element");
		Console.WriteLine("4. clear - Clear");
		Console.WriteLine("5. b - Return back");
		Console.Write(">>> ");
	}

	public void ArrayUpStackHandler(int capacity) 
	{
		var arrayUpStack = new ArrayUpStack<int>(capacity);
		while (option != "b")
		{
			PrintAvailableOperations();
			option = Console.ReadLine();
			switch (option) 
			{
				case "push":
					for (int i = 0; i < capacity; i++)
					{
						Console.Write("Element: ");
						var item = Console.ReadLine();
						arrayUpStack.Push(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (arrayUpStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.WriteLine("Items: ");
						while (!arrayUpStack.IsEmpty)
						{
							Console.Write(arrayUpStack.Pop() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (arrayUpStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {arrayUpStack.Peek()}");
					}
					break;
				case "clear":
					arrayUpStack.Clear();
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		}
	}

}
