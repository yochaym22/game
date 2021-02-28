using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("active_book");

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
   
    
}
