using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloth_changer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject red_shirt;
    public GameObject yellow_shirt;
    public GameObject jeans;
    public GameObject black_pants;

    SpriteRenderer current_sprite_clicked;
    Sprite[] player_children_sprites;


    string yellowShirt = "yellow_shirt";
    string redShirt = "red_shirt";
    string jeansPants = "jeans_pants";
    string blackPants = "black_pants";
    string hat = "hat";
     
    void Start()
    {
        player_children_sprites = player.GetComponentsInChildren<Sprite>();
        current_sprite_clicked = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(current_sprite_clicked.name == yellowShirt )
        foreach (Sprite sprite in player_children_sprites)
        {
            
        }
        else if (current_sprite_clicked.name == redShirt)
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }
        else if (current_sprite_clicked.name == jeansPants)
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }
        else if (current_sprite_clicked.name == blackPants)
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }
        else if (current_sprite_clicked.name == hat)
        {
            foreach (Sprite sprite in player_children_sprites)
            {

            }
        }


    }

}
