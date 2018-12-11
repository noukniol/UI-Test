using UnityEngine.UI;
using UnityEngine;

public class BtEvent : MonoBehaviour {

    [SerializeField]
    private GameObject buttonPrefab;
    [SerializeField]
    private int numButton = 10;


    private Transform contentParent;
    private string nameBt;
    private Color color;
    private bool _canClick = true;
    //  色のボタン用
    private void Start()
    {
        contentParent = GameObject.Find("Content").transform;
        nameBt = transform.GetComponentInChildren<Text>().text;
        color = transform.GetComponent<Image>().color;
        
    }
   
    public void ClickEvent()
    {
        if (_canClick)
        {
            for (int i = 1; i <= numButton; i++)
            {

                GameObject bt = Instantiate(buttonPrefab);
                bt.transform.SetParent(contentParent);
                bt.transform.localScale = Vector3.one;

                //  ボタンプレハブに色のボタンの属性を設定する
                bt.GetComponentInChildren<Text>().text = nameBt + i;
                bt.GetComponent<Image>().color = color;
            }
        }
        _canClick = false;

        DestroyButtonDifferentColor();
        SetInteractable();
    }
    private void DestroyButtonDifferentColor()
    {
        for(int i = 0; i < contentParent.childCount; i++)
        {
            GameObject buttonChild = contentParent.GetChild(i).gameObject;
            Color colorChild = buttonChild.GetComponent<Image>().color;

            //  複製されたボタンの色が親のボタンの色に同じではないなら削除
            if (colorChild != color)
            {
                Destroy(buttonChild);
            }
        }
    }
    private void SetInteractable()
    {
        Transform buttons = GameObject.Find("Buttons").transform;

        for(int i = 0; i < buttons.childCount; i++)
        {
            Transform buttonColor = buttons.GetChild(i);

            // 各色ボタンのクリック許可する
            if (buttonColor.name != this.name)
            {
                buttonColor.GetComponent<BtEvent>()._canClick = true;
            }
        }

    }
    // ボタンプレハブ用
    public void LogName()
    {
        string btName = transform.GetComponentInChildren<Text>().text;
        Debug.Log(btName);
    }
}
