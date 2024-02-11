using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToTitle()
    {
        SceneManager.LoadScene(0);
    }
    public void goToOptions()
    {
        SceneManager.LoadScene(1);
    }
    public void goToGame()
    {
        SceneManager.LoadScene(2);
    }
    public void goToEnd()
    {
        SceneManager.LoadScene(3);
    }
}
