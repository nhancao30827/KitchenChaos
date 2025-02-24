using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _moveSpeed = 5f;

    private void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0,  Input.GetAxis("Vertical")).normalized;

        Debug.Log(playerInput);

        Vector3 movement = playerInput * _moveSpeed *Time.deltaTime;
        this.transform.position += movement;
    }
}
