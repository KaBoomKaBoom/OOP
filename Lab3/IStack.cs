using System;

public interface IStack<T>
{
	int count { get; }
	bool isEmpty { get; }

	void Push(T item);
	T peek();
	T pop();
	void Clear();
}
