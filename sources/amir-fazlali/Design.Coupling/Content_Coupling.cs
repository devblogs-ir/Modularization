using System.Reflection;

class Money
{
    private int _money;

    public Money(int money)
    {
        _money = money;
    }

    private void PrintMoney()
    {
        Console.WriteLine(_money);
    }
}

class ChangeMoney
{
    public void Change(Money money)
    {
        FieldInfo field = typeof(Money).GetField("_money", BindingFlags.NonPublic | BindingFlags.Instance);

        int value = (int)field.GetValue(money);

        field.SetValue(money, value * 10);

        MethodInfo method = typeof(Money).GetMethod("PrintMoney", BindingFlags.NonPublic | BindingFlags.Instance);

        method.Invoke(money, null);
    }
}

// Example :
// Money money = new (10);
// ChangeMoney change = new ();
// change.Change(money);
