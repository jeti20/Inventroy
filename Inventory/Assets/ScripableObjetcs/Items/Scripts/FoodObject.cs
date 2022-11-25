using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory System/Items/Food")] // w projects po ppm i create mo¿emy mamy kolejno te zak³adki
public class FoodObject : ItemObject
{
    public int restorehealthValue;
    public void Awake()
    {
        type = ItemType.Food;
    }
}
