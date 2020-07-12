using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float rotationSpeed = 135;

    // Direccion hacia al frente o hacia atras
    public Vector3 _direction;
    public float _rotationY;

    public bool IsWalking()
    {
        return _direction.z != 0;
    }

    // Update is called once per frame // 60 veces por segundo
    void Update()
    {
        // d = v * t * K
        transform.Translate(_direction * Time.deltaTime * movementSpeed, Space.Self);

        // r = euler * t * K
        transform.Rotate(new Vector3(0f, _rotationY) * Time.deltaTime * rotationSpeed);
    }
}
