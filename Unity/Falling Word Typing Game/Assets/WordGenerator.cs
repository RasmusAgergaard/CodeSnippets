using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "word1", "word2", "word3" };

    public static string GetRadomWord()
    {
        return wordList[Random.Range(0, wordList.Length)];
    }
}
