using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDistance = 1.5f;
    [SerializeField] private float _maxHeight = 0.5f;
    [SerializeField] private GameObject _pipe;

    private float _spawnTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnerPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_spawnTime > _spawnDistance) {
            SpawnerPipe();
            _spawnTime = 0;
        }
        _spawnTime+=Time.deltaTime;
    }
    private void SpawnerPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_maxHeight, _maxHeight));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
    }
}
