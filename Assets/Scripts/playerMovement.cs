using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float gravity = -9.81f;

    private float moveSpeed = 8f;
    private float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
