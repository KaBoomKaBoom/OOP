using System;

public interface IQueue<T>
{
	int Count { get; }
	bool IsEmpty { get; }

	void Enqueue(T item);
	T Dequeue();
	T Peek();
	void Clear();
}
