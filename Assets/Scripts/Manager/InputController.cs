using UnityEngine;

public class InputController : MonoBehaviour
{
    public static InputController instance;
    public float hor, ver;
    const string HORIZONTAL = "Horizontal", VERTICAL="Vertical";
    public float rotX, rotY;
    const string MOUSEX = "Mouse X", MOUSRY = "Mouse Y";


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
        }
    }

    private void FixedUpdate()
    {
        hor = Input.GetAxisRaw(HORIZONTAL);
        ver=Input.GetAxisRaw(VERTICAL);
        rotX = Input.GetAxisRaw(MOUSEX);
        rotY=Input.GetAxisRaw(MOUSRY);  

    }




}
