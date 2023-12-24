namespace Design.Cohesion.CommunicationCohesion;

/* 
    Description: 
    this is third File.
    It is recommended to check the second file (SequentialCohesion.cs) before reading this file 
*/

public class WalletService
{
    private double WalletBalance { get; set; }

    public void IncreaseWalletBalance(double Amount) => WalletBalance += Amount;
    public void DecreaseWalletBalance(double Amount) => WalletBalance -= Amount;
    public double GetWalletBalance() => WalletBalance;
}


/*
    Description:
    IncreaseWalletBalance and DecreaseWalletBalance use same variable for save result;
*/