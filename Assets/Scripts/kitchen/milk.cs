using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milk : MonoBehaviour
{
    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("active_milk");

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

}
