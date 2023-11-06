using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingScore : MonoBehaviour
{
    ScoreManager score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.UpdateScore();
        }
    }
}
