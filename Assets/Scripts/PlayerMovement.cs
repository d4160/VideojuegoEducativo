using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
    // Direccion hacia el frente o hacia atrás
    public Vector3 _direction;
    public float _rotationY;

    // Update is called once per frame
=======
    // Direccion hacia al frente o hacia atras
    public Vector3 _direction;
    public float _rotationY;

    // Update is called once per frame // 60 veces por segundo
>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
    void Update()
    {
        // d = v * t
        transform.Translate(_direction * Time.deltaTime, Space.Self);
<<<<<<< HEAD
        transform.Rotate(new Vector3(0f,  _rotationY) * Time.deltaTime);
=======
        transform.Rotate(new Vector3(0f, _rotationY) * Time.deltaTime);
>>>>>>> 811aa957afdfa22e1b64314adc2506fa8c4a77b6
    }
}
