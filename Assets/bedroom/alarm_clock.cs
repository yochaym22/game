using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarm_clock : MonoBehaviour
{
    public void clockVisibilty ()
    {
      Renderer rend = gameObject.GetComponent<Renderer>();
      if (rend.enabled)
        rend.enabled = false;
      else
        rend.enabled = true;

    }

}
