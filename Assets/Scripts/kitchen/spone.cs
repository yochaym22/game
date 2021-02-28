using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spone : MonoBehaviour
{

    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("active_spone");

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

}
