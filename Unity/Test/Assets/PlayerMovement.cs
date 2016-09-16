using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    Vector3 moveDirection;
    public float speed = 10;
    public float gravity = 3;
    public float jumpSpeed = 30;
    CharacterController cc;

    public void StopMoving()
    {
        MoveUsingArrowKeys.MoveOnArrows -= Move;
        MoveUsingArrowKeys.RotateOnArrows -= Rotate;
    }

    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveUsingArrowKeys.MoveOnArrows += Move;
        //MoveUsingButtons.Forward += Move;
        MoveUsingArrowKeys.RotateOnArrows += Rotate;
        //MoveUsingButtons.Rotate += Rotate;
    }

    void Rotate(float _rotateInY)
    {
        transform.Rotate(0, _rotateInY, 0);
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = jumpSpeed;
        }
    }

    void Move(float _moveInZ)
    {
        moveDirection.y -= gravity;
        moveDirection.z = _moveInZ;
        moveDirection = transform.TransformDirection(moveDirection * speed * Time.deltaTime);
        cc.Move(moveDirection);
    }
}