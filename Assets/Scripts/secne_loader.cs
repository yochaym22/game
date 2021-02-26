using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class secne_loader : MonoBehaviour
{
    [SerializeField] string nextLevelName;   
    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
