using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int curClicks;
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public void AddClicks(int amount)
    {
        curClicks += amount;
        UI.instance.UpdateClickText();
    }
}
