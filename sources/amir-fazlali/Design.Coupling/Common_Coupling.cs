
class Program {
    static int global = 10;

    class Print
    {
        public void PrintGlobal()
        {
            Console.WriteLine(global);
        }
    }

    class Modify
    {
        public void ModifyGlobal()
        {
            global = 20;
        }
    }

    class CheckValue
    {
        public bool CheckGlobal()
        {
            return global > 15;
        }
    }

    class Multiple
    {
        public void MultiplyGlobal()
        {
            global *= 2;
        }
    }
}