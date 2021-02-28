using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green_brushing : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playAnimator;
    public GameObject playerHand;
    public Vector3 brush_positon;
    public Vector3 brush_roation;
    Transform brush;

    void Start()
    {
         brush = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Transform parent = brush.parent;
        brush.transform.parent = playerHand.transform;
        brush.localPosition = brush_positon;
        brush.localEulerAngles = brush_roation;
        playAnimator.SetBool("is_brushing", true);


    }
}
