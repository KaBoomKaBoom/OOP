using System;

public class ArrayDownStack<T> : IStack<T>
{
	private T[] stack;
	private int top;

	public ArrayDownStack(int capacity)
	{
		stack = new T[capacity];
		top = capacity;
	}

	public int Count => stack.Length - top;
	public bool IsEmpty => Count == 0;

	public void Push(T item)
	{
		if (top > 0)
			stack[--top] = item;
		else
			throw new InvalidOperationException("Stack is full.");
	}

	public T Pop()
	{
		if (!IsEmpty)
			return stack[top++];
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
		top = stack.Length; 
	}
}
