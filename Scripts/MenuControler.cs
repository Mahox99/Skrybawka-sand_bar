using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{
    //All scenes will be uploaded soon. :)
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoTo_Members()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToInfo()
    {
        SceneManager.LoadScene(2);
    }
    public void GoTo_AOInfo()
    {
        SceneManager.LoadScene(4);
    }
    public void GoTo_PX()
    {
        SceneManager.LoadScene(3);
    }
    public void GoTo_KC()
    {
        SceneManager.LoadScene(5);
    }
    public void GoTo_MP()
    {
        SceneManager.LoadScene(6);
    }
    public void GoTo_NB()
    {
        SceneManager.LoadScene(7);
    }
    public void GoTo_OT()
    {
        SceneManager.LoadScene(8);
    }
    public void GoTo_Other()
    {
        SceneManager.LoadScene(9);
    }
    public void GoTo_Support()
    {
        SceneManager.LoadScene(10);  
    } 
}
