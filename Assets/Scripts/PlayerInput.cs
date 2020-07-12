using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
<<<<<<< HEAD
=======
    public PlayerMovement playerMov;

>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
    // Update is called once per frame
    void Update()
    {
        float rotationValue = Input.GetAxis("Horizontal");
<<<<<<< HEAD
        float forwardValue = Input.GetAxis("Vertical");
=======

        playerMov._rotationY = rotationValue;


        float forwardValue = Input.GetAxis("Vertical");

<<<<<<< HEAD
        playerMov._direction = new Vector3(0, 0, 3 * forwardValue);
>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
=======
        playerMov._direction = new Vector3(0, 0, forwardValue);
>>>>>>> origin/diego
    }
}
