﻿using System;

public class ConsoleMenu
{
	private string option="";
	OperationHandler operationHandler = new OperationHandler();
	public void PrintOperations() 
	{
		Console.WriteLine("1. aus - Array Up Stack");
		Console.WriteLine("2. ads - Array Down Stack");
		Console.WriteLine("3. lls - Linked List Stack");
		Console.WriteLine("4. auq - Array Up Queue");
		Console.WriteLine("5. adq - Array Down Queue");
		Console.WriteLine("6. llq - Linked List Queue");
		Console.WriteLine("7. q - Quit");
		Console.Write(">>> ");
	}

	public int GetCapacity() 
	{
		Console.Write("Capacity: ");
		return Convert.ToInt32(Console.ReadLine()); ;
	}

	public void ExecOperations() 
	{
		
		while (option != "q")  
		{
			PrintOperations();
			option = "";
			option = Console.ReadLine();

			//implement a class: switch case for operations with stack/queue !!!!!!!!
			switch (option) 
			{
				case "aus":
					var capacity = GetCapacity();
					operationHandler.ArrayUpStackHandler(capacity);
					break;
				case "ads":
					capacity = GetCapacity();
					operationHandler.ArrayDownStackHandler(capacity);
					break;
				case "lls":
					capacity = GetCapacity();
					operationHandler.StackLinkListHandler(capacity);
					break;
				case "auq":
					capacity = GetCapacity();
					operationHandler.ArrayUpQueueHandler(capacity);
					break;
				case "adq":
					capacity = GetCapacity();
					operationHandler.ArrayDownQueueHandler(capacity);
					break;
				case "llq":
					capacity = GetCapacity();
					operationHandler.QueueLinkListHandler(capacity);
					break;
			}
		}
	}
}
