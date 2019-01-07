using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="Item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public string info;

}

public class ItemBase : MonoBehaviour
{
    protected void SetSprite(string n_sprite,Sprite sprite)
    {
        transform.Find(n_sprite).GetComponent<Image>().sprite = sprite;
    }
    protected void SetText(string n_info,string t_info)
    {
        transform.Find(n_info).GetComponent<Text>().text = t_info;
    }
}