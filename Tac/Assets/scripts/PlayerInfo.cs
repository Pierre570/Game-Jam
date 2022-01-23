using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class PlayerInfo
{
    public static float health = 0;
    public static float enhealth = 0;
    public static float player_max_health = 100;
    public static float enemy_max_health = 100;
    public static bool level1Cleared = false;
    public static bool level2Cleared = false;
    public static int DummySpeed = 1;
    public static float DummyMoveSpeed = 50f;

    public static void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
