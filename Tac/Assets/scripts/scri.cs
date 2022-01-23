using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scri : MonoBehaviour
{
    public Image level1Button;
    public Sprite cleared;

    void Start()
    {
        if (PlayerInfo.level1Cleared)
            level1Button.sprite = cleared;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
