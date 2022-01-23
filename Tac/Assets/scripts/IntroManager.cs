using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    private bool gameStart = false;
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        if (gameStart)
            PlayerInfo.ChangeScene("Menu");
        if (Input.GetKeyDown(KeyCode.Escape))
            gameStart = true;
        if (timer >= 18.5f)
            gameStart = true;
    }
}
