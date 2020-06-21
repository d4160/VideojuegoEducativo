using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 _direction;
    public float _rotationY;

    // Update is called once per frame // 60 veces por segundo
    void Update()
    {
        // distancia = velocidad por tiempo d = v * t
        transform.Translate(_direction * Time.deltaTime, Space.Self);
        transform.Rotate(new Vector3 (0f, _rotationY) * Time.deltaTime);
    }
}
