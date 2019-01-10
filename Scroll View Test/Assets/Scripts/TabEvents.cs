using UnityEngine.UI;
using UnityEngine;

public class TabEvents : MonoBehaviour {

    [SerializeField]
    private Color pressedBtColor = Color.blue;

    private Transform tabManager;
    private Transform tabBts;
	// Use this for initialization
	void Start () {
        tabManager = GameObject.Find("Tab Manager").transform;
        tabBts = GameObject.Find("Tab Button").transform;
	}
	
	public void ClickEvent(int no)
    {
        for(int i = 0; i < tabManager.childCount; i++)
        {
            bool flg = i == no;
            tabManager.GetChild(i).gameObject.SetActive(flg);
            tabBts.GetChild(i).GetComponent<Image>().color = flg ? pressedBtColor : Color.white;
        }
        Debug.Log(name);
    }
}
