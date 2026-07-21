using UnityEngine;
[CreateAssetMenu(fileName ="NewItem",menuName ="Collectables/Item")]
public class Collectable : ScriptableObject
{
    public string description;
    public int id;
    public Sprite sprite;
    public int amount = 1;
}
