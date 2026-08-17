using NUnit.Framework;
using SeasonsLib;

namespace SeasonsLib.Tests;

[TestFixture]
public class SeasonTellerTests
{
    private SeasonTeller season;

    [SetUp]
    public void Setup()
    {
        season = new SeasonTeller();
    }

    [Test]
    public void DisplaySeasonBy_February_ReturnsSpring()
    {
        Assert.That(season.DisplaySeasonBy("February"), Is.EqualTo("Spring"));
    }

    [Test]
    public void DisplaySeasonBy_May_ReturnsSummer()
    {
        Assert.That(season.DisplaySeasonBy("May"), Is.EqualTo("Summer"));
    }

    [Test]
    public void DisplaySeasonBy_August_ReturnsMonsoon()
    {
        Assert.That(season.DisplaySeasonBy("August"), Is.EqualTo("Monsoon"));
    }

    [Test]
    public void DisplaySeasonBy_October_ReturnsAutumn()
    {
        Assert.That(season.DisplaySeasonBy("October"), Is.EqualTo("Autumn"));
    }

    [Test]
    public void DisplaySeasonBy_January_ReturnsWinter()
    {
        Assert.That(season.DisplaySeasonBy("January"), Is.EqualTo("Winter"));
    }

    [Test]
    public void DisplaySeasonBy_InvalidMonth_ReturnsInvalidSeason()
    {
        Assert.That(season.DisplaySeasonBy("ABC"), Is.EqualTo("Invalid Season"));
    }
}

internal class SeasonTeller
{
    public string DisplaySeasonBy(string month)
    {
        return month switch
        {
            "February" => "Spring",
            "May" => "Summer",
            "August" => "Monsoon",
            "October" => "Autumn",
            "January" => "Winter",
            _ => "Invalid Season",
        };
    }
}