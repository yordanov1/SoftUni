using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void Lose_HealthWhenIs_Attacked()
    {
        int health = 6;
        int expiriance = 10;
        int attackPoints = 2;

        Dummy dummy = new Dummy(6, 10);

        dummy.TakeAttack(2);

        Assert.That(dummy.Health + attackPoints, Is.EqualTo(health));
    }

    [Test]
    public void ThrowsException_IfDeadDummyIsAttacked()
    {
        Dummy deadDummy = new Dummy(-4, 20);

        Assert.That(() =>
        {
            deadDummy.TakeAttack(2);
        }, Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead.")
        );
    }

    [Test]
    public void DeadDummy_CanGive_XP()
    {
        Dummy deadDummy = new Dummy(-4, 20);
        Assert.That(deadDummy.GiveExperience(), Is.EqualTo(20));
    }

    [Test]
    public void AliveDummy_CantGive_XP()
    {
        Dummy aliveDummy = new Dummy(100, 20);
        Assert.That(() =>
        {
            aliveDummy.GiveExperience();
        }, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
