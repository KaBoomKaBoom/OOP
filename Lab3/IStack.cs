using System;

public interface IStack<T>
{
	int Count { get; }
	bool IsEmpty { get; }

	void Push(T item);
	T Peek();
	T Pop();
	void Clear();
}
