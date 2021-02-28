using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cloth_handler : MonoBehaviour
{
    public SpriteRenderer open_closet;
    SpriteRenderer closed_closet;
    // Start is called before the first frame update
    void Start()
    {
        closed_closet = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        closed_closet.sortingOrder = 0;
        SpriteRenderer[] children = open_closet.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer sprite  in children)
        {
            if (sprite.name == "open_closet")
                sprite.sortingOrder = 2;
            else 
            {
                sprite.sortingOrder = 3;
            }
        }
    }
}
