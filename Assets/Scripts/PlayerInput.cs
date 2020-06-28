using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float rotationValue = Input.GetAxis("Horizontal");
        float forwardValue = Input.GetAxis("Vertical");
    }
}
