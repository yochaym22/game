using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bus_moving : MonoBehaviour
{

    Animator anim;
    public GameObject player;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
            player.active = false;
        }
    }
}
