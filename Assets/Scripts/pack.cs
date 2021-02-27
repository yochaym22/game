using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator glasses;
    public Animator book;
    public Transform sandwich;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    

    private void OnMouseDown()
    {
        GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
    }
}
