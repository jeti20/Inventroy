using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")] // w projects po ppm i create mo¿emy mamy kolejno te zak³adki
public class EquipmentObject : ItemObject
{
    public float attackBonus;
    public float defenceBouns;

    public void Awake()
    {
        type = ItemType.Equipment;
    }

}

