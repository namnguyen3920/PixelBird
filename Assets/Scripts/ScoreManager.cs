using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//public class ScoreManager : MonoBehaviour
//{
//    private static ScoreManager instance;
//    public static ScoreManager Instance {  get { return instance; } }

//    [SerializeField] private TextMeshProUGUI _currentScoreText;
//    [SerializeField] private TextMeshProUGUI _highestScoreText;

//    public int score = 0;
//    public int highest;

//    private void Awake()
//    {
//        if (instance == null) {
//           instance = this; 
//        }
//    }
    
//    public void AddScore(int amount)
//    {
//        score += amount;
//        if (score > highest)
//        {
//            highest = score;
//        }
//        UpdateScore();
//    }

//    public void Reset()
//    {
//        score = 0;
//    }

//    public void OnRoundOver()
//    {
//        PlayerPrefs.SetInt("Highest", highest);
//        _highestScoreText.text = highest.ToString();
//        Reset();
//    }

//    public void UpdateHighScore()
//    {
//        PlayerPrefs.SetInt("Highest", score);
//        _highestScoreText.text = highest.ToString();
//    }
//    public void UpdateScore()
//    {
//        _currentScoreText.text = score.ToString();
//        UpdateHighScore()
//    }
//}

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    public static ScoreManager Instance { get { return instance; } }

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highestScoreText;

    [SerializeField] private int _score = 0;
    [SerializeField] private int _highest;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentScoreText.text = _score.ToString();
        _highestScoreText.text = PlayerPrefs.GetInt("Highest", 0).ToString();
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("Highest"))
        {
            PlayerPrefs.SetInt("Highest", _score);
        }
    }

    public void OnRoundOver()
    {
        UpdateHighScore();
        _highestScoreText.text = _highest.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
