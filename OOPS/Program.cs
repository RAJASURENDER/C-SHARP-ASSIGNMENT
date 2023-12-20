//ASSIGNMENT 7.1
class Customer
{

    private int customerId;
    private string firstName;
    private string lastName;
    private string emailAddress;
    private string phoneNumber;
    private string address;

    public Customer()
    {
    }
    public Customer(int customerId, string firstName, string lastName, string emailAddress, string phoneNumber, string address)
    {
        this.customerId = customerId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.phoneNumber = phoneNumber;
        this.address = address;
    }
    public int CustomerId
    {
        get { return customerId; }
        set { customerId = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string EmailAddress
    {
        get { return emailAddress; }
        set { emailAddress = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public override string ToString()
    {
        return $"Customer ID: {customerId}\n" +
               $"First Name: {firstName}\n" +
               $"Last Name: {lastName}\n" +
               $"Email Address: {emailAddress}\n" +
               $"Phone Number: {phoneNumber}\n" +
               $"Address: {address}";
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(1, "John", "Doe", "john.doe@email.com", "123-456-7890", "123 Main St");

        Console.WriteLine("Customer Information:");
        Console.WriteLine(customer1.ToString());
    }
} 
 
//ASSIGNMENT 7.2



