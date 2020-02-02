const canvasWidth = window.innerWidth;
const canvasHeight = window.innerHeight;

let words = [];
let player;

//Timers
let addWordTime = 150;
let addWordTimer = addWordTime;

function setup() 
{
	createCanvas(canvasWidth, canvasHeight);
	textAlign(CENTER, CENTER);
	player = new Player();
}

function draw() 
{
	//BG
	background(51);

	//Word counter
	textSize(20);
	fill(255, 255, 255);
	text(words.length, 20, 20);

	//Player
	player.Show();

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
		//let newString = player.playerString.slice(0, -1);;
		//player.playerString = newString;

		player.ResetPlayerString();
	}
	else
	{
		player.playerString += key;
	}

	CheckWords();
}

function CheckWords()
{
	for (let i = 0; i < words.length; i++) 
	{
		if(words[i].content == player.playerString)
		{
			RemoveFromArray(words, words[i]);
			player.ResetPlayerString();
			player.AddKill();
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

function RemoveFromArray(array, what) 
{
    var found = array.indexOf(what);

	while (found !== -1) 
	{
        array.splice(found, 1);
        found = array.indexOf(what);
    }
}