using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glasses : MonoBehaviour
{

    Animator anim;
   void OnMouseDown()
    {
        anim.SetTrigger("active_glasses");

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
  
}
