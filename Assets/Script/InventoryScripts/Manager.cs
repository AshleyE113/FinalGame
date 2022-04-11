using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to pick up the item and add it to their inventory. 
 * Everything involving the inventory was possible thanks to Brackeys and CodingWithUnity!!*/
public class Manager : MonoBehaviour
{
    public InventoryObject inventory;

    public void OnTriggerEnter(Collider other) //if the player touches it, it will appear in the inventory
    {
            var item = other.GetComponent<ItemObject>();
            if (item)
            {
                inventory.AddItem(item.item);
                Destroy(other.gameObject);
            }
    }

    private void Update()
    {
        inventory.OrderByDescending(inventory.ItemContainer); //Sorts the items
    }
}
