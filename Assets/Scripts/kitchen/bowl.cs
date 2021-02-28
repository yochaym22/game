using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowl : MonoBehaviour
{

    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("active_bowl");
        anim.SetBool("bowl_on_table", true);

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

}

