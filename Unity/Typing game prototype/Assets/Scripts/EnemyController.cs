using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float speedRange;
    public string word;

    private float _movementSpeed;
    private TextMesh _text;
    private GameObject _player;
    private List<string> _words;

    public EnemyController()
    {
        _words = new List<string>()
        {
            "action",
            "break",
            "claim",
            "consider",
            "design",
            "discussion",
            "eat",
            "effect",
            "environmental",
            "fail",
            "follow",
            "government",
            "happen",
            "husband"
        };

    }

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");

        word = _words[Random.Range(0, _words.Count)].ToUpper();

        _text = GetComponentInChildren<TextMesh>();
        _text.text = word;

        //Speed
        _movementSpeed = speed + Random.Range(-speedRange, speedRange);
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        float step = _movementSpeed * Time.deltaTime; // calculate distance to move
        var targetFixed = new Vector3(_player.transform.position.x, transform.position.y, _player.transform.position.z); //Only move on the x and z axis
        transform.position = Vector3.MoveTowards(transform.position, targetFixed, step);

        if (Vector3.Distance(transform.position, _player.transform.position) < 1f)
        {
            _player.GetComponent<PlayerController>().TakeDamage(10);
            Destroy(gameObject);
        }

    }
}
