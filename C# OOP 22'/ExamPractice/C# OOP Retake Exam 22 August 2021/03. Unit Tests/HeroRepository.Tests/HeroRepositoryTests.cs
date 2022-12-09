using System;
using System.Reflection;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private string name = "Armoran";
    private int level = 3;
    private HeroRepository heroRepository;
    private Hero hero;

    [SetUp]
    public void Setip()
    {
        hero = new Hero(name, level);
        heroRepository = new HeroRepository();
    }

    [Test]
    public void TEST_CREATE_METHOD_SHOULD_THROW_EXCEPTION_IF_NULL()
    {
        hero = null;

        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepository.Create(hero);
        });
    }

    [Test]
    public void TEST_CREATE_METHOD_SHOULD_THROW_EXCEPTION_IF_EXISTING_HERO()
    {
        heroRepository.Create(hero);

        Assert.Throws<InvalidOperationException>(() =>
        {
            heroRepository.Create(hero);
        });
    }

    [Test]
    public void TEST_CREATE_METHOD()
    {
        string result = $"Successfully added hero {hero.Name} with level {hero.Level}";

        string expected = $"Successfully added hero Armoran with level 3";

        heroRepository.Create(hero);

        Assert.AreEqual(expected, result);
    }

    [TestCase(null)]
    [TestCase(" ")]
    public void TEST_REMOVE_METHOD_SHOULD_THROW_EXCEPTION_IF_NULLORWHITESPACE(string name)
    {
        //hero = null;

        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepository.Remove(name);
        });
    }
    [Test]
    public void TEST_REMOVE_METHOD_SHOULD_RETURN_TRUE_OR_FALSE()
    {
        heroRepository.Create(hero);

        bool isRemoved = heroRepository.Remove("Armoran");
        
        Assert.IsTrue(isRemoved);
    }

    [Test]
    public void TEST_GETHERO_WITH_HIGHESTLEVEL()
    {
        heroRepository.Create(hero);
        Hero hero2 = new Hero("Parker", 12);
        heroRepository.Create(hero2);
       
        Hero highestLvlHero = this.heroRepository.GetHeroWithHighestLevel();

        Assert.AreEqual(highestLvlHero, hero2);
    }

    [Test]
    public void TEST_GETHERO_RETURNS_HERO()
    {
        heroRepository.Create(hero);
        Hero hero2 = new Hero("Parker", 12);
        heroRepository.Create(hero2);

        Hero returnedHero = this.heroRepository.GetHero("Parker");

        var expected = hero2;

        Assert.AreEqual(hero2, returnedHero);
    }

    [Test]
    public void TEST_HEROREPOSITORY_SHOULD_BE_READONLY()
    {
        var type = typeof(HeroRepository);

        PropertyInfo propInfo = type.GetProperty("Heroes");

        Assert.IsFalse(propInfo.CanWrite);
    }
}