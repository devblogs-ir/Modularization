using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularization.Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    #region Content
    public class ClassA
    {
        private ClassB _dependency = new ClassB();

        public void DoSomething()
        {
            _dependency.MethodInB();
        }
    }

    public class ClassB
    {
        public void MethodInB() { /* Method logic */ }
    }

    #endregion

    #region Common
    public static class GlobalData
    {
        public static int SharedValue { get; set; }
    }

    public class ClassA
    {
        public void UseSharedValue()
        {
            int value = GlobalData.SharedValue;
            // Use the shared value
        }
    }

    public class ClassB
    {
        public void ModifySharedValue()
        {
            GlobalData.SharedValue = 10;
            // Modify the shared value
        }
    }

    #endregion

    #region Control
    public class ClassA
    {
        public void DoSomething()
        {
            ClassB dependency = new ClassB();
            dependency.PerformAction("actionName");
        }
    }

    public class ClassB
    {
        public void PerformAction(string actionName) { /* Perform action based on the name */ }
    }

    #endregion

    #region Stamp
    public class DataProcessor
    {
        public void ProcessData(Data data)
        {
            // Use only specific fields of 'Data' object
            int result = data.Value1 + data.Value2;
            // ...
        }
    }

    public class Data
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        // ...
    }

    #endregion

    #region Data
    public class ClassA
    {
        public void MethodA(int value)
        {
            ClassB dependency = new ClassB();
            dependency.MethodB(value);
        }
    }

    public class ClassB
    {
        public void MethodB(int value)
        {
            // Use the passed value
        }
    }

    #endregion

    #region Message
    public class Publisher
    {
        public event EventHandler SomethingHappened;

        public void PublishEvent()
        {
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.SomethingHappened += HandleEvent;
        }

        private void HandleEvent(object sender, EventArgs e)
        {
            // Handle the event
        }
    }

    #endregion

    #region Direct
    public class PaymentProcessor
    {
        private PayPalGateway _payPalGateway;

        public PaymentProcessor()
        {
            _payPalGateway = new PayPalGateway();
        }

        public void ProcessPayment(decimal amount)
        {
            // Direct usage of PayPalGateway
            _payPalGateway.MakePayment(amount);
        }
    }

    public class PayPalGateway
    {
        public void MakePayment(decimal amount)
        {
            // Logic to process payment via PayPal
        }
    }

    #endregion

}
