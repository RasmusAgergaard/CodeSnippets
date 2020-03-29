using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int health;

    private string _letters;
    private List<GameObject> _enemies;
    private int _score;
    private Text _uiText;
    private Text _uiHealth;
    private Text _uiScore;

    // Start is called before the first frame update
    void Start()
    {
        ResetLetters();
        FindEnemies();

        //UI
        _uiText = GameObject.Find("UiText").GetComponent<Text>();
        _uiHealth = GameObject.Find("UiHealth").GetComponent<Text>();
        _uiScore = GameObject.Find("UiScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LookForKeyboardInputs();
        LookForEnemyMatch();
        UpdateUi();
    }

    private void LookForEnemyMatch()
    {
        if (Input.anyKeyDown)
        {
            FindEnemies();

            foreach (var enemy in _enemies)
            {
                var enemyWord = enemy.GetComponent<EnemyController>().word.ToUpper();

                if (enemyWord == _letters)
                {
                    Destroy(enemy);
                    ResetLetters();
                    AddScore(1);
                    break;
                }
            }
        }
    }

    private void AddScore(int amount)
    {
        _score += amount;
    }

    private void UpdateUi()
    {
        _uiText.text = _letters;
        _uiHealth.text = "Health: " + health;
        _uiScore.text = "Score: " + _score;
    }

    private void LookForKeyboardInputs()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode))
                {
                    if (kcode.ToString() == "LeftArrow")
                    {
                        transform.position = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
                        break;
                    }

                    if (kcode.ToString() == "RightArrow")
                    {
                        transform.position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
                        break;
                    }

                    if (kcode.ToString() == "Backspace")
                    {
                        ResetLetters();
                    }
                    else
                    {
                        _letters += kcode;
                    }
                }
            }
        }
    }

    private void ResetLetters()
    {
        _letters = "";
    }

    private void FindEnemies()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        _enemies = enemies.ToList();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}
