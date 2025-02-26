using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _moveSpeed = 5f;
    private float _rotationSpeed = 20f;

    private void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0,  Input.GetAxis("Vertical")).normalized;

        Debug.Log(playerInput);
        Debug.Log(Time.deltaTime);

        Vector3 movement = playerInput * _moveSpeed *Time.deltaTime;

        this.transform.position += movement;

        this.transform.forward = Vector3.Slerp(transform.forward, movement, Time.deltaTime * _rotationSpeed);
    }
}
