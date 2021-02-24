using System.Collections;
using UnityEngine;

public class get_up : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator clock_anim;
    public Animator player_anim;
    public Transform transform;
    private int get_up_once = 0;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (get_up_once < 1)
        {
            StartCoroutine(get_up_func());
        }
        /*  if(transform.position.x <9.2)
          {
              player_anim.SetBool("is_walking", true);
              player_anim.SetBool("getting_up", false);
          }*/

        //Debug.Log(transform.position.x.ToString());



    }

    IEnumerator get_up_func()
    {
        if (!(clock_anim.GetBool("is_ringing")))
        {
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);
            Debug.Log(transform.position.z);
            player_anim.SetBool("getting_up", true);
            yield return new WaitForSeconds(1f);
         

            transform.position.Set(9.06f,9.91f,transform.position.z);
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);
            Debug.Log(transform.position.z);

            player_anim.SetBool("getting_up", false);
            player_anim.SetBool("is_brushing", true);

            get_up_once++;
        }

    }
}
