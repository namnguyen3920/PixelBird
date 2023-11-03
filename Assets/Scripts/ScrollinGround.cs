using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollinGround : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 2f;
    [SerializeField] private float _maxWidth = 6f;

    private SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _scrollSpeed * Time.deltaTime, _spriteRenderer.size.y);

        if(_spriteRenderer.size.x > _maxWidth)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}