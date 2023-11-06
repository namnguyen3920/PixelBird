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

}
