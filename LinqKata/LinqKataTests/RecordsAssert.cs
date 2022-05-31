using System.Collections.Generic;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;

namespace LinqKataTests;

public static class RecordsAssert
{
    public static void CollectionEqual<T>(IReadOnlyList<T> actual, IReadOnlyList<T> expected)
    {
        Assert.That(actual.Count, Is.GreaterThanOrEqualTo(expected.Count), "Expected is bigger than Actual");
            
        for (var i = 0; i < expected.Count; i++) 
            AreEqual(actual[i], expected[i]);
    }

    public static void AreEqual<T>(T actual, T expected)
    {
        var compareLogic = new CompareLogic
        {
            Config =
            {
                IgnoreObjectTypes = true
            }
        };

        var result = compareLogic.Compare(expected, actual);
            
        if (!result.AreEqual) 
            throw new AssertionException(result.DifferencesString);
    }
        
}