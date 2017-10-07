using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool running = false;
    public float musicVolume, gameVolume;
    public FSM gameStateMachine;
    public Player player; // count on the level loader to tell you where this is
    public InputManager inman;
    void Awake()
    {
        //sigleton stuff
        if (instance == null)
        {
            instance = this;
            //Sets global scene to not be destroyed when reloading scenes
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        gameStateMachine = GetComponent<FSM>();
        loadLevel("StartScreen");
    }
    public void loadLevel(string level)
    {
        Scene scene = SceneManager.GetSceneByName(level);
        if (scene.isLoaded == false)
        {
            SceneManager.LoadSceneAsync(level, LoadSceneMode.Additive);
        }
    }
    public void unloadLevel(string level)
    {
        Scene scene = SceneManager.GetSceneByName(level);
        if (scene.isLoaded == true)
        {
            SceneManager.UnloadSceneAsync(scene);
        }
    }
}
