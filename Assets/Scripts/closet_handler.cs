using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closet_handler : MonoBehaviour
{
    public SpriteRenderer open_closet_renderer;
    public SpriteRenderer closed_closet_renderer;
    SpriteRenderer [] children_array;
    SortingLayer[] layers;

    // Start is called before the first frame update
    void Start()
    {
        layers = SortingLayer.layers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
  
        closed_closet_renderer.sortingOrder = 0;
        open_closet_renderer.sortingOrder = 1;
        SpriteRenderer[] children = open_closet_renderer.GetComponentsInChildren<SpriteRenderer>();
        foreach(SpriteRenderer sprite in children)
        {
            if (sprite.name == "open_closet")
            {
                sprite.sortingOrder = 1;
            }
            else
            {
                sprite.sortingOrder = 2;
            }
        }


    }
}
