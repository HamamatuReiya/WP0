using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject Switch;
    public string nextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
