namespace Design.Cohesion
{
    public sealed class SmartHomeSystem
    {
        private bool _lightsOn;
        private int _currentTemperature;

        public SmartHomeSystem()
        {
            _lightsOn = false;
            _currentTemperature = 22;
        }

        public void TurnOnLights()
        {
            _lightsOn = true;
            Console.WriteLine("Lights are now turned on.");
        }

        public void TurnOffLights()
        {
            _lightsOn = false;
            Console.WriteLine("Lights are now turned off.");
        }

        public void AdjustTemperature(int newTemperature)
        {
            if (newTemperature >= 18 && newTemperature <= 28)
            {
                _currentTemperature = newTemperature;
                Console.WriteLine($"Temperature adjusted to " +
                    $"{_currentTemperature} degrees Celsius.");
            }
            else
            {
                Console.WriteLine("Invalid temperature setting. Temperature " +
                    "remains unchanged.");
            }
        }

        public void ActivateSmartMode()
        {
            TurnOnLights();
            AdjustTemperature(24);
            Console.WriteLine("Smart mode activated: Lights on and temperature" +
                " adjusted for comfort.");
        }
    }

    public sealed class SmartBankSystem
    { 
        private bool _fireAlert;
        private bool _securityAlert;

        public void FireMode()
        {
            _fireAlert = true;
            Console.WriteLine("Calling fire fighters");
        }

        public void SecurityMode()
        {
            _securityAlert = true;
            Console.WriteLine("closing all the door");
            Console.WriteLine("calling police");
        }
    }
}
