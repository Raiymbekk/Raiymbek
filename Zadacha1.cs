using System;

class Client
{
    private string firstName;
    private string lastName;
    private string accountNumber;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                firstName = value;
            else
                Console.WriteLine("Invalid first name");
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                lastName = value;
            else
                Console.WriteLine("Invalid last name");
        }
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                accountNumber = value;
            else
                Console.WriteLine("Invalid account number");
        }
    }
}

class Zadacha1
{
    static void Main()
    {
        // Пример использования класса Client
        Client client = new Client();
        client.FirstName = "John";
        client.LastName = "Doe";
        client.AccountNumber = "123456789";

        Console.WriteLine($"Client: {client.FirstName} {client.LastName}, Account Number: {client.AccountNumber}");
    }
}
