using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float movePower;
    public Rigidbody rigid;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector3.forward * movePower, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigid.AddForce(Vector3.back * movePower, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigid.AddForce(Vector3.left * movePower, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigid.AddForce(Vector3.right * movePower, ForceMode.Force);
        }
    }

}
