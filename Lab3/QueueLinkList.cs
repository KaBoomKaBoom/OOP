using System;

public class QueueLinkList<T> : IQueue<T>
{
	private LinkedList<T> queue;
	public QueueLinkList()
	{
		queue = new LinkedList<T>();
	}

	public int Count => queue.Count;
	public bool IsEmpty => Count == 0;

	public void Enqueue(T item)
	{
		queue.AddLast(item);
	}

	public T Dequeue()
	{
		if (!IsEmpty)
		{
			var item = queue.First.Value;
			queue.RemoveFirst();
			return item;
		}
		throw new InvalidOperationException("Queue is empty.");
	}

	public T Peek()
	{
		if (!IsEmpty)
			return queue.First.Value;
		throw new InvalidOperationException("Queue is empty.");
	}

	public void Clear()
	{
		queue.Clear();
	}
}
