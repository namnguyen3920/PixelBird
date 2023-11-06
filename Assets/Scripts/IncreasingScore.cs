using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingScore : MonoBehaviour
{
    public AudioClip scoredPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.PlaySound(scoredPoint);
            ScoreManager.Instance.UpdateScore();
        }
    }
}
