using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtEvents : MonoBehaviour {

    List<GameObject> btList = new List<GameObject>();

    [SerializeField]
    private GameObject buttonPrefab;

    private string nameBt;
    private Color color;
    private Transform contentParent;

    private int num = 0;
    // Use this for initialization
    void Start()
    {
        contentParent = GameObject.Find("Content").transform;
        color = transform.GetComponent<Image>().color;
        nameBt = transform.GetComponentInChildren<Text>().text;
    }
    public void AddEvent()
    {
        num++;
        GameObject bt = Instantiate(buttonPrefab);
        bt.transform.SetParent(contentParent);
        bt.transform.localScale = Vector3.one;

        //  ボタンプレハブに色のボタンの属性を設定する
        bt.GetComponentInChildren<Text>().text = nameBt + num;
        bt.GetComponent<Image>().color = color;

        btList.Add(bt);
    }
    public void RemoveEvent()
    {
        if (btList.Count > 0)
        {
            Destroy(btList[0].gameObject);
            btList.Remove(btList[0].gameObject);
        }
    }
}
