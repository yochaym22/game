using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refrigerator : MonoBehaviour
{

    public GameObject close_refrigerator;
    public GameObject open_refrigerator;
    public Animator milk;



    void OnMouseDown()
    {
        close_refrigerator.active = false;
        open_refrigerator.active = true;
        milk.SetTrigger("active_milk");


    }
    void Start()
    {
        open_refrigerator.active = false;

    }

}
