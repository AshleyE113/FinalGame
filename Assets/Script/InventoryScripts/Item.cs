using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*A class that creates the base for scriptable objects*/

[CreateAssetMenu(fileName = "InventoryItems", menuName = "InventoryMenu")] //Adds an option to the right-click drop down menu
public class Item : ScriptableObject
{
	new public string name = "InventoryItems"; //item's name
	public GameObject prefab;
}
