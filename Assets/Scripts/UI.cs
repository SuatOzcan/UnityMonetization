using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI clickText;
    public Image clickButtonImage;
    public Sprite[] buttonSprites;
    public static UI instance;

    void Awake()
    {
        instance = this;
    }
    public void OnClickButton()
    {
        GameManager.instance.AddClicks(1);
        clickButtonImage.sprite = buttonSprites[Random.Range(0, buttonSprites.Length)];
    }
    public void UpdateClickText()
    {
        clickText.text = GameManager.instance.curClicks.ToString();
    }
}
