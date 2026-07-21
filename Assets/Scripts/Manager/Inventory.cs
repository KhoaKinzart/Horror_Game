using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Pair<Collectable,int>> itemList= new List<Pair<Collectable,int>>();

    public void AddItem(Collectable col,int amount)
    {
        var targetItem=GetItem(col);
        if (targetItem != null) 
        {
            targetItem.value += amount;
        }       
        else
        {
            itemList.Add(new Pair<Collectable, int>()
            {
                key = col,
                value = amount
            });
        }
    }
    public void UseItem(Collectable col, int amount) 
    { 
        var targetItem=GetItem(col);
        if (targetItem != null) 
        { 
            targetItem.value-=amount;
            if(targetItem.value <= 0)
            {
                itemList.Remove(targetItem);
            }
        }
    }

    public Pair<Collectable, int> GetItem(Collectable col) 
    {
        foreach (var item in itemList) 
        {
            if (item.key == col)
            {
                return item;
            }
        }
        return null;
    }
}

[System.Serializable]
public class Pair<T1, T2>
{
    public T1 key;
    public T2 value;
}