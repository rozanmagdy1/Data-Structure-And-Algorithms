namespace Data_Structure
{
	internal class Queue
	{
		int front, rear, size;
		int[] q;
		public Queue(int size)
		{
			this.size = size;
			front = rear = -1;
			q = new int[size];
		}

		public bool IsFull()
		{
			return rear == size - 1;
		}

		public bool IsEmpty()
		{
			return front == -1;
		}
		public void Enqueue(int item)
		{
			if(IsFull())
			{
				Console.WriteLine("Queue Overflow!");
			}
			else
			{
				if(IsEmpty())
				{
					rear = front = 0;
				} else
				{
					rear++;
				}
				q[rear] = item;
			}

		}

		public int Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue Underflow! Cannot pop.");
				return -1;
			} else
			{
				int element = q[front];
				if (rear == front) //only one item
				{
					rear = front = -1;
				}
				else
				{
					front++;
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
