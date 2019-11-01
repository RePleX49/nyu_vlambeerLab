using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int WorldTileCount = 0;
    public static int pathMakerCount = 1;
    private static GameController instance = null;

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }    
    }

    private void Start()
    {
        Debug.Log("Instance: " + WorldTileCount);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            WorldTileCount = 0;
            pathMakerCount = 1;
            SceneManager.LoadScene("mainLabScene");
        }
    }
}
