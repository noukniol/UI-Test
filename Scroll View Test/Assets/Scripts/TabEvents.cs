using UnityEngine.UI;
using UnityEngine;

public class TabEvents : MonoBehaviour {

    [SerializeField]
    private Color pressedBtColor = Color.blue;
    [SerializeField]
    private GameObject item;
    [SerializeField]
    private int nums;

    private Transform tabManager;
    private Transform tabBts;
	// Use this for initialization
	void Start () {
        tabManager = GameObject.Find("Tab Manager").transform;
        tabBts = GameObject.Find("Tab Button").transform;
        ClickEvent(0);
        AddItem();
    }
    public void AddItem()
    {
        if (item == null) return;
        for (int i = 0; i < nums; i++)
        {
            GameObject itemGO = (GameObject)Instantiate(item);
            itemGO.transform.SetParent(tabManager.Find(this.name));
            itemGO.transform.localScale = Vector3.one;
        }
    }
	public void ClickEvent(int no)
    {
        for(int i = 0; i < tabManager.childCount; i++)
        {
            bool flg = i == no;
            tabManager.GetChild(i).gameObject.SetActive(flg);
            tabBts.GetChild(i).GetComponent<Image>().color = flg ? pressedBtColor : Color.white;
        }
    }
}
