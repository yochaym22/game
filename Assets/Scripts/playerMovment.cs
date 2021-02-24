using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;
    public float runSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent < Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerRigidBody !=null)
        {
            ApplayInput();
        }
        else
        {

        }
    }
    public void ApplayInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        float xForce = xInput * runSpeed * Time.deltaTime;

        Vector2 force = new Vector2(xForce, 0);
        playerRigidBody.AddForce(force);
        Debug.Log("xforce " + xForce);
       // Debug.Log("velocity " + playerRigidBody.velocity);
        
    }

}
