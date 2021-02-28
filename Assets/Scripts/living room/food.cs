using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{

    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("Active_food");

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

}
