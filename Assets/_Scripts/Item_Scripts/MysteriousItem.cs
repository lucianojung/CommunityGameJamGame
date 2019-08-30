using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MysteriousItem", menuName = "Inventory/MysteriousItem")]
public class MysteriousItem : ScriptableObject
{
    public List<Item> items = new List<Item>();
    public Item activeItem;
    public int itemPos;

    // Start is called before the first frame update
    void Start()
    {
        itemPos = 0;

        //activeItem = items.Get(itemPos);
    }

    public bool Add(Item item)
    {
        items.Add(item);
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }

    public List<Item> getItems()
    {
        return this.items;
    }
}
