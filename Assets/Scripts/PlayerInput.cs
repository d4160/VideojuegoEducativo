using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerMovement playerMov;
    // Update is called once per frame
    void Update()
    {
        float rotationValue = Input.GetAxis("Horizontal");

        playerMov._rotationY = 45 * rotationValue;

        float forwardValue = Input.GetAxis("Vertical");

        playerMov._direction = new Vector3(x: 0, y: 0, z: 3 * forwardValue);
    }
}
