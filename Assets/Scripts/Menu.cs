using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnClickStart(){
        SceneManager.LoadScene(1);
    } 

    public void OnClickTutorial(){
        SceneManager.LoadScene(2);
    } 
}
