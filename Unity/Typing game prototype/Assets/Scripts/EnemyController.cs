using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;
    private Transform _playerTransform;
    private List<string> _words;
    public string word;
    private TextMesh _text;

    public EnemyController()
    {
        _words = new List<string>()
        {
            "Word",
            "Dead",
            "Cow",
            "Ping",
            "Flower",
            "Car",
            "Bob"
        };

    }

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

        word = _words[Random.Range(0, _words.Count)];

        _text = GetComponentInChildren<TextMesh>();
        _text.text = word;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        if (Vector3.Distance(transform.position, _playerTransform.position) > 0.001f)
        {
            float step = speed * Time.deltaTime; // calculate distance to move
            var targetFixed = new Vector3(_playerTransform.position.x, transform.position.y, _playerTransform.position.z); //Only move on the x and z axis
            transform.position = Vector3.MoveTowards(transform.position, targetFixed, step);
        }
    }
}
