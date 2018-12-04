using UnityEngine.UI;
using UnityEngine;

public class BtEvent : MonoBehaviour {

    public void ClickEvent()
    {
        string btName = transform.GetComponentInChildren<Text>().text;
        Debug.Log(btName);
    }
}
