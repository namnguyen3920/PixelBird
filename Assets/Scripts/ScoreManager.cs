using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance {  get { return instance; } }

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highestScoreText;

    private int _score = 0;

    private void Awake()
    {
        if (ScoreManager.instance == null) { ScoreManager.instance = this; }
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentScoreText.text = _score.ToString();

        _highestScoreText.text = PlayerPrefs.GetInt("Highest", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("Hightest"))
        {
            PlayerPrefs.SetInt("Highest", _score);
            _highestScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        
    }
}
