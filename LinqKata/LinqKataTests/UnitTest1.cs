using System;
using LinqKata;
using NUnit.Framework;

namespace LinqKataTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var data = new DataProcessor();

        var customers = data.GetCustomers("org 1");
        
        RecordsAssert.AreEqual(customers, new []
        {
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"}
        });
    }
    
    [Test]
    public void Test2()
    {
        var data = new DataProcessor();

        var customers = data.GetCustomers("org 2");
        
        RecordsAssert.AreEqual(customers, new []
        {
            new Customer { Organization = "org 2"},
            new Customer { Organization = "org 2"},
        });
    }
    
    [Test]
    public void Test3()
    {
        var data = new DataProcessor();

        var customers = data.GetAllCustomers();
        
        RecordsAssert.AreEqual(customers, new []
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
        });
    }
    
    [Test]
    public void Test4()
    {
        var data = new DataProcessor();

        var ids = data.GetOrganizationIds();
        
        RecordsAssert.AreEqual(ids, new []
        {
            "org 1", "org 2", "org 3"
        });
    }
    
    [Test]
    public void Test5()
    {
        var data = new DataProcessor();

        var ids = data.GetOrganizationIdsJoined();
        
        Assert.That(ids, Is.EqualTo("org 1, org 2, org 3"));
    }
    
    [Test]
    public void Test6()
    {
        var data = new DataProcessor();

        var customers = data.GetTop3Customers();
        
        RecordsAssert.AreEqual(customers, new []
        {
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"},
            new Customer { Organization = "org 1"}
        });
    }

}

