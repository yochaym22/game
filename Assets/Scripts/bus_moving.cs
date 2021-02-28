using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bus_moving : MonoBehaviour
{
    [SerializeField] string nextLevelName;

    Animator anim;
    public GameObject player;

    void Start()
    {

        anim = gameObject.GetComponent<Animator>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
            player.SetActive(false);
        }
        StartCoroutine(load_end());
    }
    IEnumerator load_end()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(nextLevelName);

    }
}
