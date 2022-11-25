using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// rozszerza ItemObject class z innego skryptu.
[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")] // w projects po ppm i create mo�emy mamy kolejno te zak�adki
public class DefaultObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Default; //domy�lnie przypisuje ItemType Default 
    }
}
