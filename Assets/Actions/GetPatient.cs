using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPatient : GAction //as this is a nurse action, it inherits from GAction --this serves as a fairly basic 'stock standard' action
{
    GameObject resource;

    public override bool PrePerform()
    {
        target = GWorld.Instance.RemovePatient();
        if (target == null)
            return false;
        resource = GWorld.Instance.RemoveCubicle();
        if (resource != null)
            inventory.AddItem(resource);
        else
        {
            GWorld.Instance.AddPatient(target);
            target = null;
            return false;
        }

        GWorld.Instance.GetWorld().ModifyState("FreeCubicle", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("Waiting", -1); //here a waiting patient is removed from queue
        if (target)
            target.GetComponent<GAgent>().inventory.AddItem(resource); //cubicle is added to the patient's inv
        return true;
    }
}
