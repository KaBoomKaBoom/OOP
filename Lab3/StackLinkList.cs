using System;

public class StackLinkList<T> : IStack<T>
{
	private LinkedList<T> stack;
	public StackLinkList()
	{
		stack = new LinkedList<T>();
	}

	public int Count => stack.Count;
	public bool IsEmpty => Count == 0;

	public void Push(T item) 
	{
		stack.AddLast(item);
	}

	public T Pop() 
	{
		if (!IsEmpty)
		{
			var item = stack.Last.Value;
			stack.RemoveLast();
			return item;
		}
		throw new InvalidOperationException("Stack is empty.");
	}

	public T Peek()
	{
		if (!IsEmpty)
			return stack.Last.Value;
		throw new InvalidOperationException("Stack is empty.");
	}

	public void Clear()
	{
		stack.Clear();
	}
}
