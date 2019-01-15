using UnityEngine;

public class InfoPopup : ItemBase {

    public void CloseItemInfo()
    {
        BtEvents.canOpenPopup = true;
        Destroy(gameObject);
    }
    public void SetInfoPopup(Item item)
    {
        SetSprite("Item Sprite", item.sprite);
        SetText("Item Name", item.itemName);
        SetText("Item Info", item.info);
    }
}
