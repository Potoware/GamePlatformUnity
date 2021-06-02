using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
   {
      
       collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
   }
}
