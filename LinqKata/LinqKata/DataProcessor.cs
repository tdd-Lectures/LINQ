namespace LinqKata;

public class DataProcessor
{
    public IEnumerable<Customer> GetCustomers(string org)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAllCustomers() => Customers.AllCustomers;

    public IEnumerable<string> GetOrganizationIds()
    {
        throw new NotImplementedException();
    }

    public string GetOrganizationIdsJoined()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetTop3Customers()
    {
        throw new NotImplementedException();
    }
}

public record Customer
{
    public string Organization { get; init; }
    public int Id { get; init; }
    public Invoice[] Invoices { get; set; }
}

public static class Customers
{
    public static readonly IEnumerable<Customer> AllCustomers = new[]
    {
        new Customer {Id = 1, Organization = "org 1", Invoices = new []
        {
            new Invoice { Id = 1, Value = 200.0 },
            new Invoice { Id = 2, Value = 150.0 },
        }},
        new Customer {Id = 2, Organization = "org 1", Invoices = Array.Empty<Invoice>()},
        new Customer {Id = 3, Organization = "org 1", Invoices = Array.Empty<Invoice>()},
        new Customer {Id = 4, Organization = "org 1", Invoices = Array.Empty<Invoice>()},
        new Customer {Id = 5, Organization = "org 2", Invoices = Array.Empty<Invoice>()},
        new Customer {Id = 6, Organization = "org 2", Invoices = Array.Empty<Invoice>()},
        new Customer {Id = 7, Organization = "org 3", Invoices = Array.Empty<Invoice>()},
    };
}

public record Invoice
{
    public int Id { get; init; }
    public double Value { get; init; }
}