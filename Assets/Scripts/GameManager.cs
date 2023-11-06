using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject pipeSpawner;

    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _scoreUI;
    [SerializeField] private GameObject _gameStartCanvas;

    public AudioClip hitObject;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null) {
            GameManager.instance = this;
        }
        Time.timeScale = 1f;
    }
   
    public void GameOver()
    {
        SoundManager.Instance.PlaySound(hitObject);
        _gameOverCanvas.SetActive(true);
        _gameStartCanvas.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreManager.Instance.OnRoundOver();
    }

    public void PlayingGame()
    {

        bird.GetComponent<BirdController>().SetGravityScale(1f);
        _gameStartCanvas.SetActive(false);
        pipeSpawner.SetActive(true);
        _scoreUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void StartGame() {
        pipeSpawner.SetActive(false);
        _gameStartCanvas.SetActive(true);
        bird.GetComponent<BirdController>().SetGravityScale(0f);
    }

}
