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

	//handler for ArrayUpStack
	public void ArrayUpStackHandler(int capacity) 
	{
		var arrayUpStack = new ArrayUpStack<int>(capacity);
		do
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
						Console.Write("Items: ");
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
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}

	//handler for ArrayDownStack
	public void ArrayDownStackHandler(int capacity)
	{
		var arrayDownStack = new ArrayDownStack<int>(capacity);
		do
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
						arrayDownStack.Push(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (arrayDownStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.Write("Items: ");
						while (!arrayDownStack.IsEmpty)
						{
							Console.Write(arrayDownStack.Pop() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (arrayDownStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {arrayDownStack.Peek()}");
					}
					break;
				case "clear":
					arrayDownStack.Clear();
					break;
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}

	//handler for StackLinkList
	public void StackLinkListHandler(int capacity)
	{
		var linkedListStack = new StackLinkList<int>();
		do
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
						linkedListStack.Push(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (linkedListStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.Write("Items: ");
						while (!linkedListStack.IsEmpty)
						{
							Console.Write(linkedListStack.Pop() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (linkedListStack.IsEmpty)
					{
						Console.WriteLine("Stack is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {linkedListStack.Peek()}");
					}
					break;
				case "clear":
					linkedListStack.Clear();
					break;
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}

	//handler for ArrayUpQueue
	public void ArrayUpQueueHandler(int capacity)
	{
		var arrayUpQueue = new ArrayUpQueue<int>(capacity);
		do
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
						arrayUpQueue.Enqueue(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (arrayUpQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.Write("Items: ");
						while (!arrayUpQueue.IsEmpty)
						{
							Console.Write(arrayUpQueue.Dequeue() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (arrayUpQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {arrayUpQueue.Peek()}");
					}
					break;
				case "clear":
					arrayUpQueue.Clear();
					break;
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}

	//handler for ArrayDownQueue
	public void ArrayDownQueueHandler(int capacity)
	{
		var arrayDownQueue = new ArrayDownQueue<int>(capacity);
		do
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
						arrayDownQueue.Enqueue(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (arrayDownQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.Write("Items: ");
						while (!arrayDownQueue.IsEmpty)
						{
							Console.Write(arrayDownQueue.Dequeue() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (arrayDownQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {arrayDownQueue.Peek()}");
					}
					break;
				case "clear":
					arrayDownQueue.Clear();
					break;
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}

	//handler for QueueLinkList
	public void QueueLinkListHandler(int capacity)
	{
		var linkedListQueue = new QueueLinkList<int>();
		do
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
						linkedListQueue.Enqueue(Convert.ToInt32(item));
					}
					break;
				case "pop":
					if (linkedListQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.Write("Items: ");
						while (!linkedListQueue.IsEmpty)
						{
							Console.Write(linkedListQueue.Dequeue() + " ");
						}
						Console.ReadLine();
					}
					break;
				case "peek":
					if (linkedListQueue.IsEmpty)
					{
						Console.WriteLine("Queue is empty!");
					}
					else
					{
						Console.WriteLine($"Top element: {linkedListQueue.Peek()}");
					}
					break;
				case "clear":
					linkedListQueue.Clear();
					break;
				case "b":
					break;
				default:
					Console.WriteLine("Invalid operation!");
					break;
			}
		} while (option != "b");
	}
}
