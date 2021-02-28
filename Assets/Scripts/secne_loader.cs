using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class secne_loader : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    BoxCollider collider;


    SpriteRenderer sprite;
    public Animator playerAnimator;

    public Animator bowl;
    public Animator spone;
    public Animator cereal;

    public Animator glasses;
    public Animator food;
    public Animator book;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider>();
        collider.enabled = false;
        sprite.enabled = false;


    }
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "start_menu")
        {
            sprite.enabled = true;
            collider.enabled = true;
        }

        if (SceneManager.GetActiveScene().name == "bedroom_schene")
        {
           if (playerAnimator.GetBool("get_up_done"))
            {
                collider.enabled = true;
                Debug.Log("collider " + collider.enabled);
                sprite.enabled = true;

            }
        }

        if (SceneManager.GetActiveScene().name == "bathroom_schene2")
        {
            if (playerAnimator.GetBool("is_brushing"))
            {
                collider.enabled = true;
                Debug.Log("collider " + collider.enabled);
                sprite.enabled = true;

            }

        }

        if (SceneManager.GetActiveScene().name == "kitchen")
        {
            if (bowl.GetBool("bowl_on_table")
                && spone.GetBool("spone_on_table")
                    && cereal.GetBool("cereal_on_table"))
            {
                sprite.enabled = true;
                collider.enabled = true;
            }

        }

        if (SceneManager.GetActiveScene().name == "living room")
        {

            if (glasses.GetBool("glasses_packed")
                && book.GetBool("book_packed")
                    && food.GetBool("food_packed"))
            {

                sprite.enabled = true;
                collider.enabled = true;
            }

        }

        if (SceneManager.GetActiveScene().name == "outside"){
            sprite.enabled = true;
            collider.enabled = true;
        }

    }

    
   
    private void OnMouseDown()
    {
        if (sprite.enabled == true && collider.enabled ==true  )
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
