using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    // Direccion hacia el frente o hacia atrás
    public Vector3 _direction;
    public float _rotationY;

    // Update is called once per frame
=======
=======
    public float movementSpeed = 5;
    public float rotationSpeed = 135;

>>>>>>> origin/diego
    // Direccion hacia al frente o hacia atras
    public Vector3 _direction;
    public float _rotationY;

    public bool IsWalking()
    {
        return _direction.z != 0;
    }

    // Update is called once per frame // 60 veces por segundo
>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
    void Update()
    {
<<<<<<< HEAD
        // d = v * t
        transform.Translate(_direction * Time.deltaTime, Space.Self);
<<<<<<< HEAD
        transform.Rotate(new Vector3(0f,  _rotationY) * Time.deltaTime);
=======
        transform.Rotate(new Vector3(0f, _rotationY) * Time.deltaTime);
>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
=======
        // d = v * t * K
        transform.Translate(_direction * Time.deltaTime * movementSpeed, Space.Self);

        // r = euler * t * K
        transform.Rotate(new Vector3(0f, _rotationY) * Time.deltaTime * rotationSpeed);
>>>>>>> origin/diego
    }
}
