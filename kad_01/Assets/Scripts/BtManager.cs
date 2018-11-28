using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BtManager : MonoBehaviour {
    public Button[] buttons;
	// Use this for initialization
	void Start () {
        // 最初ボタン２押せないように設定
        ClickEvent(2);
    }
    public void ClickEvent(int no)
    {
        for (int i = 1; i < buttons.Length; i++)
        {
            //  同じ番号を入れたら、押した時、押せないようにする
            //  同時に同じではないボタンが押せるようにする
            buttons[i].interactable = i != no;
        }
    }
}
