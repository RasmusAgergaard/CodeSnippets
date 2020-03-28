using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public string letters;
    public Text text;

    private List<GameObject> _enemies;

    // Start is called before the first frame update
    void Start()
    {
        letters = "";
        text = GameObject.Find("UiText").GetComponent<Text>();
        FindEnemies();
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
                //TODO: Fix this mess
                //var enemyText = enemy.word
            }

            
        }
    }

    private void UpdateUi()
    {
        text.text = letters;
    }

    private void LookForKeyboardInputs()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode))
                {
                    if (kcode.ToString() == "Backspace")
                    {
                        letters = "";
                    }
                    else
                    {
                        letters += kcode;
                    }
                }
            }
        }
    }

    private void FindEnemies()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        _enemies = enemies.ToList();
    }
}
