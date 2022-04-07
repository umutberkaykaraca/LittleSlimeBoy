using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject GameOverTrigger;
    public GameObject GameWinTrigger;
    public AudioClip die;
    public AudioClip jump;
    public AudioClip win;
    private AudioSource audi;

    //A private audiosource was defined to add multiple voices to the character. 
    void Start()
    {
       audi = GetComponent<AudioSource>();
    }

    //Play "jump" sound when character jumps.
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            audi.clip = jump;
            audi.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Stop the time. Open the "Gameover" screen. Play "die" sound when the character hits the enemy.
        if (col.tag=="Enemy")
        {
            
            GameOverTrigger.SetActive(true);
            Debug.Log("You died.");
            Time.timeScale = 0;

            audi.clip = die;
            audi.Play();
           
            
        }

        //Open the "GameWin" screen. Play "win" sound when the character hits the chest.
        if (col.tag=="Finish")
        {
            GameWinTrigger.SetActive(true);
            Debug.Log("You win!");

            audi.clip = win;
            audi.Play();
            
        }
        
        
    }
    
    //Start the time. It opens the main scene when the Play button is pressed.
    public void TryAgain()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    } 
    
}
