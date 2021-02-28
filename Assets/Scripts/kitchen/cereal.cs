using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cereal : MonoBehaviour
{

    Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("active_cereal");
        anim.SetBool("cereal_on_table", true);

    }
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }


}
