using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to move around so they can pick up the objects for their inventory.*/
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical") * -1; //Allows the up button to move the player up and the down button to move the player down
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
    }
}
