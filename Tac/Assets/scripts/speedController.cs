using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedController : MonoBehaviour
{
    public void boostSpeed()
    {
        if (PlayerInfo.DummySpeed <= 3) {
            PlayerInfo.DummySpeed += 1;
            PlayerInfo.DummyMoveSpeed += 100;
        }
        else if (PlayerInfo.DummySpeed < 5) {
            PlayerInfo.DummySpeed += 1;
            PlayerInfo.DummyMoveSpeed += 50;
        }
    }
    public void lowerSpeed()
    {
        if (PlayerInfo.DummySpeed <= 3 && PlayerInfo.DummySpeed > 1) {
            PlayerInfo.DummySpeed -= 1;
            PlayerInfo.DummyMoveSpeed -= 50;
        }
        else if (PlayerInfo.DummySpeed <= 5 && PlayerInfo.DummySpeed > 1) {
            PlayerInfo.DummySpeed -= 1;
            PlayerInfo.DummyMoveSpeed -= 100;
        }
    }
}
