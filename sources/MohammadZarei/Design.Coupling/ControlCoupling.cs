namespace Design.Coupling
{
    public sealed class Order
    {
        public required Guid Id { get; init; }
        public required decimal Price { get; init; }
    }

    public sealed class OrderProcessorService
    {
        public void Process(Order order, bool isFinished)
        {
            
            if (isFinished)
            {
                // process the order and send it to receiver
            }
            else
            {
                // just process it
            }
        }
    }

    public sealed class OrderService
    {
        private readonly OrderProcessorService _orderProcessorService;

        public OrderService(OrderProcessorService orderProcessorService)
        {
            _orderProcessorService = orderProcessorService;
        }

        public void Place(Order order)
        {
            Console.WriteLine("Doing placement logic . . .");

            _orderProcessorService.Process(order: order, isFinished: true);
        }
    }
}
