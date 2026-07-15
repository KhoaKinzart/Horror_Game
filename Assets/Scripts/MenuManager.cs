using UI;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GenericButton[] buttonArrays = null;
    void Start()
    {
        buttonArrays[0].SetUp("Load Game", GameManager.instance.LoadGame);
        buttonArrays[1].SetUp("New Game", GameManager.instance.NewGame);
        buttonArrays[2].SetUp("Options", GameManager.instance.Options);
        buttonArrays[3].SetUp("Quit Game", GameManager.instance.QuitGame);   


    }

   
}
