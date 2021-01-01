using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : GAction //as this is a patient action, it inherits from GAction --this serves as a fairly basic 'stock standard' action
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.RemoveState("exhausted");
        return true;
    }
}
