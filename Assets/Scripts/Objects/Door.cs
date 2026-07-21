using UnityEngine;

public class Door : Interactable
{
    [SerializeField] Request request=new Request();
    [SerializeField] bool doorIsLocked = true;

    public override void Init()
    {
        base.Init();
        Debug.Log("Door Init called");
        request.onCompleteRequest = delegate
        {
            Debug.Log("onCompleteRequest invoked!");
            doorIsLocked = false;
        };
    }

    public override void Interaction()
    {
        if (doorIsLocked)
        {
            var targetItem=GameManager.instance.inventory.GetItem(request.requiredObject);
            if (targetItem != null) 
            {
                GameManager.instance.inventory.UseItem(targetItem.key, 1);
                request.CompleteRequest();
                    
            }
        }
        else
        {

        }
    }

}
