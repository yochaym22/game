using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_up : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator clock_anim;
    public Animator player_anim;
    public Transform transform; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!(clock_anim.GetBool("is_ringing")))
        {
            player_anim.SetBool("getting_up", true);
            
        }
        //Debug.Log(transform.position.x.ToString());



    }
}
