using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollinGround : MonoBehaviour
{

    private Vector3 startPos;
    [SerializeField] private float speed = 1f;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

        if (transform.position.x <= -0.02f)
        {
            transform.position = startPos;
        }
    }

    


    //[SerializeField] private float _scrollSpeed = 2f;
    //[SerializeField] private float _maxWidth = 6f;

    //private SpriteRenderer _spriteRenderer;

    //private Vector2 _startSize;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    _spriteRenderer = GetComponent<SpriteRenderer>();

    //    _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _scrollSpeed * Time.deltaTime, _spriteRenderer.size.y);

    //    if (_spriteRenderer.size.x > _maxWidth)
    //    {
    //        _spriteRenderer.size = _startSize;
    //    }
    //}
}
