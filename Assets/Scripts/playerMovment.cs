using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    Rigidbody2D playerRigidBody;
    [SerializeField] float runSpeed = 0f;
    public Animator clock_animator;
    public Animator player_animator;
    Animation [] animations;
    Vector2 position;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
        animations = GameObject.FindObjectsOfType<Animation>();
        foreach(Animation anim in animations )
        {
            if(anim.name =="player_get_up")
            {
                Debug.Log(anim.localBounds.center.x);
            }
        }    

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (playerRigidBody !=null)
        {
            StartCoroutine(get_up_func());
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

    IEnumerator get_up_func()
    {
        if(clock_animator != null)
        {
            if (!(clock_animator.GetBool("is_ringing")) && (!(player_animator.GetBool("get_up_done"))))
            {


                player_animator.SetBool("getting_up", true);
                yield return new WaitForSeconds(2.7f);
                player_animator.SetBool("getting_up", false);
                player_animator.SetBool("get_up_done", true);
                playerRigidBody.position = new Vector2(2f, -2.5f);
                playerRigidBody.rotation = 0f;

            }
        }
        if (player_animator.GetBool("get_up_done"))
        {
            ApplayInput();
        }
    }
}
