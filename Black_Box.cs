using System;

class Black_Box<T>
{
    private T variable;

    public T Variable 
    {
        set 
        {
            variable = value;   
        }
        get 
        {
            return variable;
        } 
    }

	public Black_Box(T value)
    {
        Variable = value;
    }
}

