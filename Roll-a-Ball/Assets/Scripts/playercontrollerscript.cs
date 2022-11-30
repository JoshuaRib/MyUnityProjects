using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrollerscript : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<vector2>();
    }
}
