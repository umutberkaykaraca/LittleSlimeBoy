using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

   //It opens the main scene when the Play button is pressed.
   public void PlayGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }

   //It exits the game when the Quit button is pressed.
   public void QuitGame()
   {
      Application.Quit();
      Debug.Log("App closed.");
   } 
   
    //It opens the main menu when the Main Menu button is pressed.
   public void ReturnToMainMenu()
   {
      SceneManager.LoadScene("MainMenu");
   }
} 