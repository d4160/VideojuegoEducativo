using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public PlayerMovement playerMov;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMov.IsWalking())
            _anim.SetFloat("Speed", 1f);
        else
        {
            _anim.SetFloat("Speed", 0f);
        }
    }
}
