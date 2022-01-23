using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTraining : MonoBehaviour
{
    public void ExitTrainingMode()
    {
        PlayerInfo.ChangeScene("Menu");
    }
}
