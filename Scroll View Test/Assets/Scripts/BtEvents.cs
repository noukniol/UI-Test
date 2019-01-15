using UnityEngine;

public class BtEvents : ItemBase {

    [SerializeField]
    private Item item;
    [SerializeField]
    private GameObject itemInfoPopup;

    private Transform itemInfoParent;
    static public bool canOpenPopup = true;
    private void Start()
    {
        SetSprite("Item Sprite", item.sprite);
        SetText("Item Name", item.itemName);

        itemInfoParent = GameObject.Find("Item Info Parent").transform;
    }
    public void EventClick()
    {
        if (canOpenPopup)
        {
            GameObject iInfo = (GameObject)Instantiate(itemInfoPopup);
            iInfo.transform.SetParent(itemInfoParent);
            iInfo.transform.localPosition = Vector3.zero;
            iInfo.transform.localScale = Vector3.one;

            iInfo.GetComponent<InfoPopup>().SetInfoPopup(item);
        }
        canOpenPopup = false;
    }
}
