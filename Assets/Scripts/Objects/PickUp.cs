using UnityEngine;

public class PickUp : Interactable
{
    [SerializeField] Collectable collectable=null;
    public override void Interaction()
    {
        if (collectable != null) 
        { 
            GameManager.instance.inventory.AddItem(collectable,collectable.amount);
            Destroy(gameObject);
        }
        
    }

}
