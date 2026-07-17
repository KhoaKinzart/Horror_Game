using UnityEngine;

public class ActionController : MonoBehaviour
{

    const string interactable = "Interactable";
    Transform target, lastTarget;
    Transform cam;
    [SerializeField] float rayLength=15;
    void Start()
    {
        cam = Camera.main.transform;
    }


    void Update()
    {
        RaycastAction();
    }

    void RaycastAction()
    {
        target = null;
        Ray ray=new Ray(cam.position,cam.forward);
        RaycastHit[] hits=Physics.RaycastAll(ray,rayLength);
        foreach (var hit in hits) 
        { 
            if(hit.transform.tag == interactable)
            {
                target = hit.transform;
            }
        }
        if (target != null) 
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Interactable foundTarget=target.GetComponent<Interactable>();
                if (foundTarget != null) 
                {
                    foundTarget.Interaction();
                }
            }
        }
        lastTarget = target;
       
    }
}
