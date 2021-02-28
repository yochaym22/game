using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class secne_loader : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    BoxCollider collider;
    SpriteRenderer sprite;
    public Scene local_scene;
    public Animator playerAnimator;

    public Animator bowl;
    public Animator spone;
    public Animator cereal;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider>();
        collider.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(local_scene.name == "bedroom_schene")
        {
            if(playerAnimator.GetBool("get_up_done"))
            {
                collider.enabled = true;
            }
        }
        if (local_scene.name == "bathroom")
        {

        }

        if (local_scene.name == "kitchen")
        {
            if(bowl.GetBool("bowl_on_table"))
            {
                sprite.enabled = true;
                collider.enabled = true;
            }

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
