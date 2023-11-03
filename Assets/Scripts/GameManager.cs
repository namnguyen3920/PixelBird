using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    [SerializeField] private GameObject _gameOverCanvas;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null) {
            GameManager.instance = this;
        }
        Time.timeScale = 1f;
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
