using UnityEngine;
[System.Serializable]
public struct Request 
{
    //1.khi hoan thanh thi sau do lam gi=>system.action=>invoke de kich hoat
    //2.yeu cau vat pham hay dieu kien gi khong
    //3.1 bien bool de check xem la quest do da hoan thanh hay chua
    public System.Action onCompleteRequest;
    public Collectable requiredObject;
    public bool objectiveIsCompleted;

    public void CompleteRequest() 
    { 
        objectiveIsCompleted = true;
        if(onCompleteRequest != null) onCompleteRequest();
    }
}
