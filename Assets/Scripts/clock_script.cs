using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_script : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;


    void Start()
    {
     
       animator.SetBool("is_ringing", true);
      

    }
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("is_ringing", false);
        }
    }
}
