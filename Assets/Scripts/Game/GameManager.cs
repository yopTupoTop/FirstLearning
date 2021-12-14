using System.Collections;
using System.Collections.Generic;
using Level;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnDeath;
    public UnityEvent OnStart;
    void Start()
    {
        PlayerController.OnDie += PlayerOnDeath;
    }

    private void PlayerOnDeath()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        OnStart?.Invoke();
        Debug.Log("Start Game");
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
