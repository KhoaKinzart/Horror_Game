using UnityEngine;



public class PlayerController : MonoBehaviour

{

    [SerializeField] float MoveSpeed = 3f;

    [SerializeField] float MoveMultiplier = 1f;

    [SerializeField] float RotSpeed = 3f;

    [SerializeField] float RotMultiplier = 1f;

    CharacterController characterController;

    bool invertedCamera = false;

    [SerializeField] Transform pivot = null;


    float cameraPitch = 0f;

    float hor, ver;



    void Start()

    {

        characterController = GetComponent<CharacterController>();

    }



    void Update()

    {

        HandleMove(Time.deltaTime);

        HandleRotation(Time.deltaTime);
        ShowCursor(false);

    }



    private void HandleMove(float deltaTime)

    {

        hor = InputController.instance.hor;

        ver = InputController.instance.ver;

        Vector3 moveDir = (transform.right * hor) + (transform.forward * ver);

        moveDir *= MoveSpeed * MoveMultiplier * deltaTime;

        characterController.Move(moveDir);





    }



    private void HandleRotation(float deltaTime)

    {

        float rotX = InputController.instance.rotX;

        float rotY = InputController.instance.rotY;

        Vector3 transformRot = new Vector3(0, rotX, 0) * RotSpeed * RotMultiplier;

        transform.Rotate(transformRot);

        float yAmount = (invertedCamera == true) ? rotY : -rotY;

        //if (invertedCamera == true) yAmount = rotY; else yAmount = -rotY;

        yAmount *= RotSpeed * RotMultiplier;

        cameraPitch += yAmount;
        cameraPitch = Mathf.Clamp(cameraPitch, -45, 45);
        pivot.localRotation=Quaternion.Euler(cameraPitch, 0, 0);

    }
    public void ShowCursor(bool val)
    {
        Cursor.visible = val;
        Cursor.lockState = val ? CursorLockMode.None : CursorLockMode.Locked;
    }

}

