using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverp : MonoBehaviour
{
    public GameObject gamepanel;
   
   
 void OnMouseDown()
    {
        if(GameObject.FindGameObjectWithTag("black") == null){
            gamepanel.SetActive(true);
             Time.timeScale = 0.2f;
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
