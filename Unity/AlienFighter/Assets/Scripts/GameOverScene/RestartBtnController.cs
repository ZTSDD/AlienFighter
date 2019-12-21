using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtnController : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
