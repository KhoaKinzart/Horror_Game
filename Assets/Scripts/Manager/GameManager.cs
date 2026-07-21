using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Inventory inventory { get;private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            inventory=GetComponentInChildren<Inventory>();
        }
    }

    public void NewGame()
    {
        string LevelName = "NewGame";
        StartCoroutine(LoadSceneAsync(LevelName));

    }

    public void LoadGame()
    {
        Debug.Log("Load Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    } 
        

    
}
