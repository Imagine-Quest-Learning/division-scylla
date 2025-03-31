using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// script for buttons that switches scenes (in Menu and Tutorial scenes)
public class Menu : MonoBehaviour
{
    public void OnClickBack(){
        SceneManager.LoadScene(0); //going back to menu from tutorial
    } 
    public void OnClickStart(){
        SceneManager.LoadScene(1); // game scene
    } 

    public void OnClickTutorial(){
        SceneManager.LoadScene(2); // tutorial scene
    } 
}
