using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private Rigidbody rigid;
    private AnimationManagerUI ani;

    private float rSpeed;
    private float mSpeed;
    private int yRotation;
    private int zMovement;
    private Vector3 movement;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        ani = GameObject.Find("AnimationManagerUI").GetComponent<AnimationManagerUI>();
        mSpeed = 5f;
        rSpeed = 2.5f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ani.SetAnimation_Run();
            zMovement = 1;
        }

        if (Input.GetKey(KeyCode.A))
            yRotation = -1;

        if (Input.GetKey(KeyCode.D))
            yRotation = 1;

        if (Input.GetKeyUp(KeyCode.W))
        {
            zMovement = 0;
            ani.SetAnimation_Idle();
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            yRotation = 0;

        movement = transform.forward.normalized * zMovement;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = movement * mSpeed * Time.fixedDeltaTime;
        rigid.rotation = Quaternion.Euler(rigid.rotation.eulerAngles + new Vector3(0, yRotation, 0) * rSpeed);
        rigid.MovePosition(rigid.position  + velocity);
    }

}
