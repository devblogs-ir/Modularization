namespace Design.Coupling
{
    class GlobalData
    {
        public static int MaxDays = 10;
    }

    class OrderService
    {
        void SendOrder()
        {
            GlobalData.MaxDays += 1;
        }

        void AddOrder()
        {
            GlobalData.MaxDays += 5;
        }
    }

    class PayService
    {
        void Pay()
        {
            GlobalData.MaxDays = 3;
        }
    }
}