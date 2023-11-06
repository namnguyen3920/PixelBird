using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    private BirdController instance;
    public BirdController Instance {  get { return instance; } }

    [SerializeField] private float _flySpeed = 3f;
    [SerializeField] private float _rotation = 10f;
    [SerializeField] private GameObject _gameStartCanvas;
    Rigidbody2D rb;
    private bool _isStart = false;
    private bool canMove = true;

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!canMove) {  return ; }
        BirdFlap();
    }
    private void FixedUpdate()
    {
        BirdRotate();
    }

    private void BirdFlap()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * _flySpeed;
            _isStart = true;
        }

        if (_isStart)
        {
            GameManager.Instance.PlayingGame();
        }
        else { GameManager.Instance.StartGame(); }
    }

    private void BirdRotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * _rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
        canMove = false;
        Time.timeScale = 0f;
    }
    public void SetGravityScale(float scale)
    {
        GetComponent<Rigidbody2D>().gravityScale = scale;
    }
}
