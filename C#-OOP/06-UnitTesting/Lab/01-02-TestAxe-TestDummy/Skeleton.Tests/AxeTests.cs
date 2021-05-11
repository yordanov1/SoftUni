using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 6;
    private Axe axe;
    private Dummy dummy;


    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack, durability);
        dummy = new Dummy(5, 6);
    }

    [Test]
    public void When_AxeAttackAndDurabilityProvided_Should_BeSetCorrectly()
    {       
        Assert.AreEqual(axe.AttackPoints, attack);
        Assert.AreEqual(axe.DurabilityPoints, durability);
    }

    [Test]
    public void When_AxeAttacks_Should_LoseDurabilityPoints()
    {
        axe.Attack(dummy);

        Assert.AreEqual(durability - 1, axe.DurabilityPoints);
    }

    [Test]
    public void When_AxeDurabilityPoints_Are_Zero_ShouldThrowException() 
    {
        dummy = new Dummy(5000, 5000);                        
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
        {
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy );
            }
        });

        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));

        Assert.That(() =>
        {
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy);
            }
        }, Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }

    [Test]
    public void When_AxeAttackIsCAlledWithNullDummy_ShouldThrowNullRef()
    {
        Assert.Throws<NullReferenceException>(() => 
        {
            axe.Attack(null);
        });
    }
}