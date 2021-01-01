using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToWaitingRoom : GAction //as this is a patient action, it inherits from GAction --this serves as a fairly basic 'stock standard' action
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        GWorld.Instance.AddPatient(this.gameObject);
        beliefs.ModifyState("atHospital", 1);
        return true;
    }
}
