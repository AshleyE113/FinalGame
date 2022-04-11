using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/*This class puts an item into the inventory and holds the function that will sort them by using a linq*/
[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System")] //Adds another option to the right-click dropdown menu
public class InventoryObject : Item
{
    public List<InventorySlot> ItemContainer = new List<InventorySlot>(); //Creates a new list of slots
    public void AddItem(Item _item) //Adds the item if it isn't in the inventory
    {
        bool inInventory = false;
        for (int i = 0; i < ItemContainer.Count; i++)
        {
            if (ItemContainer[i].item == _item)
            {
                inInventory = true; //if the item is in there, this is true

                break;
            }
        }

        if (!inInventory)
        {
            ItemContainer.Add(new InventorySlot(_item)); //if it doesn't exist, add a new to the list
        }
    }

    public void OrderByDescending(List<InventorySlot> Container)
    {
       Container.Sort((itemX, itemY) => itemY.item.name.CompareTo(itemX.item.name)); //Sorts the item's names in descending alphabetical order

        foreach (var game_item in Container)
        {
            Debug.Log(game_item.item.name); //prints it out in the consolde
        }

    }
}

[System.Serializable]

public class InventorySlot //Represents the slots that will hold the items
{
    public Item item;
    [SerializeField] int slots;

    public InventorySlot(Item _item)
    {
        item = _item;
    }

}

