class Square 
{
    public int DoSomething(int number)
    {
        return number * number;
    }
}

class Cube 
{
    public int DoSomething(int number)
    {
        return number * number * number;
    }
}

class Factorial 
{
    public int DoSomething(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Calculate
{
    public int DoSomething(int number)
    {
        Square sq = new ();
        Cube cu = new ();
        Factorial fa = new ();

        return (sq.DoSomething(number) + cu.DoSomething(number))  / fa.DoSomething(number);
    }
}
