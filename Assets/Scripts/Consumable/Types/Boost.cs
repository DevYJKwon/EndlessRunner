using UnityEngine;
using System;
using System.Collections;

public class Boost : Consumable
{

    public override string GetConsumableName()
    {
        return "Boost";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.BOOST;
    }

    public override int GetPrice()
    {
        return 1;
    }

	public override int GetPremiumCost()
	{
		return 0;
	}

    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        //speed boost
        c.trackManager.speed = c.trackManager.maxSpeed;
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        c.trackManager.speed = c.trackManager.minSpeed;
    }
}
