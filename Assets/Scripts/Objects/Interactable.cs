using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    const string objTag = "Interactable";
    private void Start()
    {
        Init();
    }
    public virtual void Init()
    {
        gameObject.tag = objTag;
    }

    public virtual void Interaction()
    {

    }

    public virtual void Esamine()
    {

    }

    public virtual void ShowDetails()
    {

    }
}
