using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Librer�a que permite la carga/descarga de escenas

public class SceneManagement : MonoBehaviour
{
    public int specificSceneToLoad;


    public void SceneLoader(int sceneToLoad)
    {
        //Esta acci�n carga la escena del espacio igual al entero que indiquemos
        SceneManager.LoadScene(sceneToLoad);
    }

    public void SceneLoaderOnPlay()
    {
        SceneManager.LoadScene(specificSceneToLoad);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
