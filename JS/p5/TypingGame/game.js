const canvasWidth = 600;
const canvasHeight = 600;

let playerString = "";
let playerStringX = canvasWidth / 2;
let playerStringY = canvasHeight - 30;

let words = [];

//Timers
let addWordTime = 150;
let addWordTimer = addWordTime;

function setup() 
{
	createCanvas(canvasWidth, canvasHeight);
	textAlign(CENTER, CENTER);
}

function draw() 
{
	//BG
	background(51);

	//Player square
	fill(255, 255, 255);
	rect(50, canvasHeight - 60, canvasWidth - 100, 50, 20);

	//Player text
	textSize(40);
	fill(0, 0, 0);
	text(playerString, playerStringX, playerStringY);

	//Word
	for (let i = 0; i < words.length; i++) 
	{
		words[i].Update();
		words[i].Show();	
	}

	AddWord();

	console.log(words.length);
	
}

function keyPressed() 
{
	if(keyCode === BACKSPACE)
	{
		//Remove last character of string
		let newString = playerString.slice(0, -1);;
		playerString = newString;	
	}
	else
	{
		playerString += key;
	}

	CheckWords();
}

function CheckWords()
{
	for (let i = 0; i < words.length; i++) 
	{
		if(words[i].content == playerString)
		{
			RemoveFromArray(words, words[i]);
			ResetPlayerString();
		}
	}
}

function AddWord()
{
	addWordTimer++;

	if(addWordTimer >= addWordTime)
	{
		addWordTimer = 0;
		words.push(new Word());
	}	
}

function ResetPlayerString()
{
	playerString = "";
}

function RemoveFromArray(array, what) 
{
    var found = array.indexOf(what);

	while (found !== -1) 
	{
        array.splice(found, 1);
        found = array.indexOf(what);
    }
}