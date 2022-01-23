using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2Button : MonoBehaviour
{
    public Image level2;
    public Sprite cleared;

    void Start()
    {
        if (PlayerInfo.level2Cleared)
            level2.sprite = cleared;
    }
    public void ChangeScene()
    {
        if (PlayerInfo.level1Cleared == true)
            PlayerInfo.ChangeScene("Level2");
    }
}
