using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloth_changer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Sprite cloths_array;

    SpriteRenderer current_sprite_clicked;
    SpriteRenderer [] player_children_sprites;
    Sprite[] redShirt;
    Sprite[] yellowShirt;
    Sprite[] blackPants;
    Sprite[] jeansPants;
    Sprite[] hat;

     
    void Start()
    {
        player_children_sprites = player.GetComponentsInChildren<SpriteRenderer>();
        current_sprite_clicked = GetComponent<SpriteRenderer>();
        redShirt = Resources.LoadAll<Sprite>("red_shird");
        yellowShirt = Resources.LoadAll<Sprite>("yellow_shirt");
        blackPants = Resources.LoadAll<Sprite>("black_pants");
        jeansPants = Resources.LoadAll<Sprite>("blue_jeans");
        hat = Resources.LoadAll<Sprite>("hat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnMouseDown()
    {
        if(current_sprite_clicked.name == "yellow_shirt" )
        {
            foreach (SpriteRenderer spriteRenderer in player_children_sprites)
            {
                if (spriteRenderer.name == "body")
                {
                    spriteRenderer.sprite = yellowShirt[0];
                }
                if (spriteRenderer.name == "left_shoulder")
                {
                    spriteRenderer.sprite = yellowShirt[1];
                }
                if (spriteRenderer.name == "right_shoulder")
                {
                    spriteRenderer.sprite = yellowShirt[2];
                }
            }
        }
        if (current_sprite_clicked.name == "black_pants")
        {
            foreach (SpriteRenderer spriteRenderer in player_children_sprites)
            {
                if (spriteRenderer.name == "hips")
                {
                    spriteRenderer.sprite = blackPants[0];
                }
                if (spriteRenderer.name == "left_leg")
                {
                    spriteRenderer.sprite = blackPants[1];
                }
                if (spriteRenderer.name == "right_leg")
                {
                    spriteRenderer.sprite = blackPants[2];
                }
            }
        }
        /*
        else if (current_sprite_clicked.name == "red_shirt")
        {
            foreach (Sprite sprite in player_children_sprites)
            {
                
            }
        }
        else if (current_sprite_clicked.name == "jeans_pants")
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }
        else if (current_sprite_clicked.name == "black_pants")
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }
        else if (current_sprite_clicked.name == "hat")
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }*/


    }
    
}
