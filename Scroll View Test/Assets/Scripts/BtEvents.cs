
public class BtEvents : ItemBase {
    public Item item;
    private void Start()
    {
        SetSprite("Item Sprite", item.sprite);
        SetText("Item Name", item.itemName);
    }
    public void EventClick()
    {
        Info.instance.SetInfoPanel("Open");
        Info.instance.SetInfo(item);
    }
}
