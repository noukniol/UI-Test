using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BtManager : MonoBehaviour {

    public GameObject buttonPrefab;
    public Transform contentParent;
    public int numButton = 10;

	// Use this for initialization
	void Start () {
        for (int i = 1; i <= numButton; i++)
        {
            GameObject bt = Instantiate(buttonPrefab);
            bt.transform.SetParent(contentParent);
            bt.transform.localScale = Vector3.one;
            bt.GetComponentInChildren<Text>().text = "Button " + i;
        }
	}
}
