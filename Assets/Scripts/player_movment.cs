using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour
{
    Rigidbody2D playerRigidBody;
    [SerializeField] float runSpeed = 0f;
    public Animator player_animator;
    Vector2 position;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (playerRigidBody != null)
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
        Vector2 force = new Vector2(xForce, playerRigidBody.velocity.y);
        playerRigidBody.velocity = force;
        player_animator.SetFloat("speed", Mathf.Abs(playerRigidBody.velocity.x));



    }


}
