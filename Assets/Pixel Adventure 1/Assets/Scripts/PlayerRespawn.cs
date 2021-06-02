using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
 
    private float checkPointPostionX,checkPointPostionY;
    public Animator animator;
    
    void Start()
    {
        if(PlayerPrefs.GetFloat("checkPointPostionX")!=0){
            transform.position= (new Vector2(PlayerPrefs.GetFloat("checkPointPostionX"),PlayerPrefs.GetFloat("checkPointPostionY")));
        }
    }

    public void ReachedCheckPoint(float x, float y){
        PlayerPrefs.SetFloat("checkPointPostionX",x);
        PlayerPrefs.SetFloat("checkPointPostionY",y);
    }
    

    public void PlayerDamaged(){
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
       

    }
}
