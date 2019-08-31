using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public MysteriousItem mysteriousItem;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking Up " + mysteriousItem.name);
        bool wasPickedUp = Inventory.instance.Add(mysteriousItem);
        if (wasPickedUp)
            Destroy(gameObject);
    }
}
