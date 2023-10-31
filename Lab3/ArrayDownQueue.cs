using System;

public class ArrayDownQueue<T> : IQueue<T>
{
	private T[] queue;
	private int front;
	private int back;
	public ArrayDownQueue(int capacity)
	{
		queue = new T[capacity];
		front = -1;
		back = 0;
	}

	public int Count => back - front - 1;

	public bool IsEmpty => Count == 0;

	public void Enqueue(T item)
	{
		if (back < queue.Length)
			queue[back++] = item;
		else
			throw new InvalidOperationException("Queue is full.");
	}

	public T Dequeue()
	{
		if (!IsEmpty)
			return queue[++front];
		throw new InvalidOperationException("Queue is empty.");
	}

	public T Peek()
	{
		if (!IsEmpty)
			return queue[front + 1];
		throw new InvalidOperationException("Queue is empty.");
	}

	public void Clear()
	{
		front = -1;
		back = -0;
	}
}
