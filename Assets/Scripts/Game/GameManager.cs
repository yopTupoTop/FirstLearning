using System.Collections;
using System.Collections.Generic;
using Level;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnDeath;
    void Start()
    {
        PlayerController.OnDie += PlayerOnDeath;
    }

    private void PlayerOnDeath()
    {
        Time.timeScale = 0f;
        OnDeath?.Invoke();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
