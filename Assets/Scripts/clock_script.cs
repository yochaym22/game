using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_script : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("is_ringing", true);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    {
        Debug.Log("imhere");
        animator.SetBool("is_ringing", false);
        Debug.Log(animator.GetBool("is_ringing"));
    }

}
