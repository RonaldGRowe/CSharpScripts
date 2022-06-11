class MinStack
{
    public Stack<int> stack = new ();
    public Stack<int> minStack = new ();
    


    public void Push(int value)
    {
        this.stack.Push(value);
        if ((!this.minStack.Any()) || value <= this.minStack.Peek())
        {
            this.minStack.Push(value);
        }
    }

    public void Pop()
    {
        if (this.stack.Peek() == this.minStack.Peek())
        {
            this.minStack.Pop();
        }
        this.stack.Pop();
    }

    public int Top()
    {
        return this.stack.Peek();
    }

    public int GetMin()
    {
        return this.minStack.Peek();
    }

}