using System;

public interface IQueue<T>
{
	int count { get; }
	bool isEmpty { get; }

	void Enqueue(T item);
	T Dequeue();
	T Peek();
	void Clear();
}
