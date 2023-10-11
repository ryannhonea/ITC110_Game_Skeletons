using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public CharacterBrain CharacterBrain;

   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           CharacterBrain.health++;
           Destroy(this.gameObject);
       }
   }
}
