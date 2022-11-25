using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory; // dodaliœmy inventory do gracza

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }

    private void OnApplicationQuit() // po wy³¹czeniu gry pesetuje wartoœæ podniesionych rzeczy
    {
        inventory.Container.Clear();
    }
}
