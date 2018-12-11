using UnityEngine.UI;
using UnityEngine;

public class BtEvent : MonoBehaviour {

    [SerializeField]
    private GameObject buttonPrefab;

    private Transform contentParent;
    private string nameBt;
    private Color color;
    private int num = 0;
    //  色のボタン用
    private void Start()
    {
        contentParent = GameObject.Find("Content").transform;
        nameBt = transform.GetComponentInChildren<Text>().text;
        color = transform.GetComponent<Image>().color;
        
    }

    public void ClickEvent()
    {
        num++;
        GameObject bt = Instantiate(buttonPrefab);
        bt.transform.SetParent(contentParent);
        bt.transform.localScale = Vector3.one;

        //  ボタンプレハブに色のボタンの属性を設定する
        bt.GetComponentInChildren<Text>().text = nameBt + num;
        bt.GetComponent<Image>().color = color;
    }
   
    // ボタンプレハブ用
    public void LogName()
    {
        string btName = transform.GetComponentInChildren<Text>().text;
        Debug.Log(btName);
    }
}
