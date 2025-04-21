namespace Data_Structure
{
	internal class Dequeue
	{
		int front, rear, size;
		int[] q;
		public Dequeue(int size)
		{
			this.size = size;
			front = rear = -1;
			q = new int[size];
		}

		public bool IsFull()
		{
			return (rear == size - 1 && front == 0) || (front == rear + 1);
		}

		public bool IsEmpty()
		{
			return front == -1;
		}

		public void InsertFront(int item)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue Overflow!");
			}
			else
			{
				if (IsEmpty())
				{
					rear = front = 0;
				}
				else if (front == 0)
				{
					front = size - 1;
				}
				else
				{
					front--;
				}
				q[front] = item;
			}
		}

		public void InsertRear(int item)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue Overflow!");
			}
			else
			{
				if (IsEmpty())
				{
					rear = front = 0;
				}
				else if (rear == size - 1)
				{
					rear = 0;
				}
				else
				{
					rear++;
				}
				q[rear] = item;
			}
		}

		public int DequeueFront()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue Uderflow!");
				return -1;
			}
			else
			{
				int element = q[front];
				if (rear == front)
				{
					rear = front = -1;
				}
				else if (front == size - 1)
				{
					front = 0;
				}
				else
				{
					front++;
				}
				return element;
			}
		}

		public int DequeueRear()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue Uderflow!");
				return -1;
			}
			else
			{
				int element = q[rear];
				if (rear == front)
				{
					rear = front = -1;
				}
				else if (rear == 0)
				{
					rear = size - 1;
				}
				else
				{
					rear--;
				}
				return element;
			}
		}

		public void Display()
		{
			for (int i = front; i <= rear; i++)
			{
				Console.Write(q[i] + " ");
			}
		}
	}
}
