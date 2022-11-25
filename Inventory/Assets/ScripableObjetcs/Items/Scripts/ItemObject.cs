using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//

public enum ItemType
{
    Food,
    Equipment,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type; //store info waht type the item is

    [TextArea(15,29)]
    public string description;
}
