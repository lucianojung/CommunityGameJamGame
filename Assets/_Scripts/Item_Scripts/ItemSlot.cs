using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image icon;
    public Text nameText;

    MysteriousItem mysteriousItem;

    public void AddItem(MysteriousItem newMysteriousItem)
    {
        mysteriousItem = newMysteriousItem;

        icon.sprite = mysteriousItem.activeItem.image;
        nameText.text = mysteriousItem.activeItem.name;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        mysteriousItem = null;

        icon.sprite = null;
        icon.enabled = false;
    }
}
