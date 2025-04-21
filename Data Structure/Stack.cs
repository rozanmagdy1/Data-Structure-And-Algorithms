namespace Data_Structure
{
	internal class Stack
	{
		public int top, size;
		public int[] s;
		public Stack(int size)
		{
			this.size = size;
			s = new int[size];
			top = -1;
		}

		public bool IsFull()
		{
			return top == size - 1;
		}

		public bool IsEmpty()
		{
			return top == - 1;
		}

		public void Push(int item)
		{
			if(!IsFull())
			{
				s[++top] = item;
			}
			else
			{
				Console.WriteLine("Stack Overflow! Cannot push.");
			}
		}

		public int Pop()
		{
			if (!IsEmpty())
			{
				return s[top--];
			}
			else
			{
				Console.WriteLine("Stack Underflow! Cannot pop.");
				return -1;
			}
		}

		public int Peek()
		{
			if (!IsEmpty())
			{
				return s[top];
			}
			else
			{
				Console.WriteLine("Stack is empty! No top element.");
				return -1;
			}
		}

		public void Display()
		{
			for (int i = 0; i <= top; i++)
			{
				Console.Write(s[i] + " ");
			}
		}
	}
}
