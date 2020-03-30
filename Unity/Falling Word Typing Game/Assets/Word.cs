using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string MainWord { get; set; }

	private int typeIndex;
	private WordDisplay _wordDisplay;

	public Word(string word, WordDisplay wordDisplay)
	{
		MainWord = word;
		typeIndex = 0;

		_wordDisplay = wordDisplay;
		_wordDisplay.SetWord(word);
	}

	public char GetNextLetter()
	{
		return MainWord[typeIndex];
	}

	public void TypeLetter()
	{
		typeIndex++;
		//Remove letter
	}

	public bool WordTyped()
	{
		var wordtyped = (typeIndex >= MainWord.Length);

		if (wordtyped)
		{
			//remove the word on screen
		}

		return wordtyped;
	}
}
