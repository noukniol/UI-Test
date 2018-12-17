using UnityEngine;
using UnityEngine.UI;

public class DebugEvent : MonoBehaviour {

    public void LogName()
    {
        string btName = transform.GetComponentInChildren<Text>().text;
        Debug.Log(btName);
    }
}
