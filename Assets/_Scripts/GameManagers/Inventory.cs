using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singelton
    public static Inventory instance;

    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than One instance of Inventory found!");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    private const int SLOTS = 5;
    public List<MysteriousItem> items = new List<MysteriousItem>();

    public bool Add (MysteriousItem mysteriousitem)
    {
        if (items.Count >= SLOTS)
        {
            Debug.Log("Not enough room.");
            return false;
        }
        items.Add(mysteriousitem);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

        return true;
    }

    public void Remove(MysteriousItem mysteriousitem)
    {
        items.Remove(mysteriousitem);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
