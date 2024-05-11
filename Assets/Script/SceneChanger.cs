using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public string sceneName;
    public int sceneBuildIndex;


    public void ChangeScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }

    //public void ChangeScene(string sceneName)
    //{
    //    SceneManager.LoadScene(sceneName);
    //}


}
