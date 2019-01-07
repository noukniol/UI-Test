
public class Info : ItemBase {

    static public Info instance;

    private void Start()
    {
        if (!instance)
            instance = this;

        SetInfoPanel(false);
    }
    public void SetInfoPanel(bool flg)
    {
        gameObject.SetActive(flg);
    }
    public void SetInfo(Item item)
    {
        SetSprite("Item Sprite", item.sprite);
        SetText("Item Name", item.itemName);
        SetText("Item Info", item.info);
    }
}
