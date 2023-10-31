using System;

public class ArrayUpStack<T> : IStack<T>
{
	private T[] stack;
	private int top;

	public ArrayUpStack(int capacity) 
	{
		stack = new T[capacity];
		top = -1;
	}

	public int Count => top + 1;
	public bool IsEmpty => Count == 0;

	public void Push(T item)
	{
		if (Count < stack.Length)
			stack[++top] = item;
		else
			throw new InvalidOperationException("Stack is full.");
	}

	public T Pop()
	{
		if (!IsEmpty)
			return stack[top--];
		throw new InvalidOperationException("Stack is empty.");
	}

	public T Peek()
	{
		if (!IsEmpty)
			return stack[top];
		throw new InvalidOperationException("Stack is empty.");
	}

	public void Clear()
	{
		top = -1;
	}
}
