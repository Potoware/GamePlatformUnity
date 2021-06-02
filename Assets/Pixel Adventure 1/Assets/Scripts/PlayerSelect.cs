using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerSelect : MonoBehaviour
{
    public enum Player{Frog,VirtualGuy,PinkMan, IronMan};
    private Player playerSelected;
    private int index;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playerRenderer;   

    void Start()
    {

        
        switch(playerSelected)
        {
            case Player.Frog:
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playerRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
            break;
            case Player.PinkMan:
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;

            case Player.IronMan:
            spriteRenderer.sprite = playerRenderer[3];
            animator.runtimeAnimatorController = playersController[3];
                break;
            default:
            
                break;
                
        
        
        }
    }

    void Update()
    {
        switch(PlayerPrefs.GetInt("Player")){
case 0: playerSelected = Player.Frog;
break;
case 1: playerSelected = Player.PinkMan;
break;
case 2: playerSelected = Player.VirtualGuy;
break;
case 3: playerSelected = Player.IronMan;
break;
default: playerSelected = Player.PinkMan;
break;
        }
        switch(playerSelected)
        {
            case Player.Frog:
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                
                
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playerRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
            break;
            case Player.PinkMan:
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
                case Player.IronMan:
                spriteRenderer.sprite = playerRenderer[3];
                animator.runtimeAnimatorController = playersController[3];
                break;
            default:
                break;
                
        
        
        }
    }

  public void btnFrog()
    {
        playerSelected = Player.Frog; 
        PlayerPrefs.SetInt("Player",0);
    }
    
      public void btnPinkMan()
    {
        playerSelected = Player.PinkMan; 
        PlayerPrefs.SetInt("Player",1);
    }
    
      public void btnVirtualGuy()
    {
        playerSelected = Player.VirtualGuy; 
        PlayerPrefs.SetInt("Player",2);
    }
      public void btnIronMan()
    {
        playerSelected = Player.IronMan; 
        PlayerPrefs.SetInt("Player",3);
    }

      public void btnIGet()
    {
       
        SceneManager.LoadScene("Menu");
    }
    
    
    
}
