using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class secne_loader : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    BoxCollider2D collider2D;
    SpriteRenderer sprite;
    public Scene local_scene;
    public Animator playerAnimator;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(local_scene.name == "bedroom")
        {
            if(playerAnimator.GetBool("get_up_done"))
            {
                sprite.enabled = true;
                collider2D.enabled = true;
            }
        }
        if (local_scene.name == "bathroom")
    }
    private void OnMouseDown()
    {
        if (sprite.enabled == true && collider2D.enabled ==true  )
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
