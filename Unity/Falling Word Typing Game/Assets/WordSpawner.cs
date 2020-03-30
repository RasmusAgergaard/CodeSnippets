using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;

    public WordDisplay SpawnWord()
    {
        var wordObject = Instantiate(wordPrefab);
        var wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
