using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScene : MonoBehaviour
{

  

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playerRenderer;   

    public void btnFrog()
    {
        spriteRenderer.sprite = playerRenderer[0];
        animator.runtimeAnimatorController = playersController[0];  
    }
 
}