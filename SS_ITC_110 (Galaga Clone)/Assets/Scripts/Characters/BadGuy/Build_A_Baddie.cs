using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;
    public Vector3 homePos;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
        homePos = new Vector3 (0,0,0);
    }

    private void Update()
    {
        if (Vector3.Distance(this.gameObject.transform.position, badGuyBrain.player.transform.position) <= 4.75f)
        {
            Explode();
        }
    }

    public void Explode()
    {
        Debug.Log(homePos);
        badGuyBrain.player.GetComponent<CharacterBrain>().health--;
        transform.position = homePos;
    }
}
