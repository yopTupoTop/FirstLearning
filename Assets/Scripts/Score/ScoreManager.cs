using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Level;

public class ScoreManager : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    void Update()
    {
        ScoreText.text = Player.position.x.ToString("0") + Player.position.z.ToString("0");
    }
}
