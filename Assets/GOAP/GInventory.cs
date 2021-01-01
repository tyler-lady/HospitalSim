using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GInventory
{
    List<GameObject> items = new List<GameObject>();

    public void AddItem(GameObject i)
    {
        items.Add(i);
    }

    public GameObject FindItemWithTag(string tag)
    {
        foreach(GameObject i in items)
        {
            if (i.tag == tag)
            {
                return i;
            }
        }
        return null;
    }

    public void RemoveItem(GameObject i)
    {
        //we loop first before removing the item because it works better with our list
        int indexToRemove = -1;
        foreach(GameObject g in items)
        {
            indexToRemove++;
            if (g == i)
                break;
            //when we reach the index for our item to remove, we break out of the loop to keep the index the same
        }
        if (indexToRemove >= -1)
            items.RemoveAt(indexToRemove);

    }
}
