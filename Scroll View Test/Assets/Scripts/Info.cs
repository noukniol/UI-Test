using UnityEngine;

public class Info : ItemBase {

    static public Info instance;

    [SerializeField]
    private Animator anim;

    private void Start()
    {
        if (!instance)
            instance = this;

        anim.Play("Close");
    }
    public void SetInfoPanel(string status)
    {
        anim.Play(status);
    }
    public void SetInfo(Item item)
    {
        SetSprite("Item Sprite", item.sprite);
        SetText("Item Name", item.itemName);
        SetText("Item Info", item.info);
    }
}
