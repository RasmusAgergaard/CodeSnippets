let gameAreaWidth

if(window.innerWidth <= 400)
{
	gameAreaWidth = window.innerWidth;
}
else
{
	gameAreaWidth = 400;
}

let startFrameRate = 8
let currentFrameRate;
let gameAreaHeight = gameAreaWidth;
let controlsAreaHeight = gameAreaHeight / 2.4;
let controlButtonSize = 50;
let controlsX = gameAreaWidth / 2 - (controlButtonSize / 2);
let controlsY = gameAreaHeight + 10	;
let gridSize = 20;
let snake;
let food;
let scoreCurrent = 0;
let scoreBest = 0;
let imageLogo;
let imageLogoWidth = gameAreaWidth - 20;
let imageLogoHeight = imageLogoWidth * 0.1325;

function setup() 
{
	frameRate(startFrameRate);
	createCanvas(gameAreaWidth, gameAreaHeight + controlsAreaHeight);

	snake = new Snake();
	snake.ResetPosition();
	pickLocation();

	textAlign(CENTER, CENTER);

	imageLogo = loadImage('images/cp_logo.png');
}

function draw() 
{
	//BG
	background(51);

	//Frame rate
	currentFrameRate = startFrameRate + (scoreCurrent / 4)
	frameRate(currentFrameRate);

	//Images
	image(imageLogo, (gameAreaWidth / 2) - (imageLogoWidth / 2), (gameAreaHeight / 2) - (imageLogoHeight / 2), imageLogoWidth, imageLogoHeight);

	//Snake
	snake.Death();
	snake.Update();
	snake.Show();

	//Food
	if(snake.Eat(food))
	{
		pickLocation();
	}

	fill(255, 0, 100);
	rect(food.x, food.y, gridSize, gridSize);

	//Points text
	textSize(20);
	fill(255, 0, 100);
	text("Score: " + scoreCurrent + " | Best: " + scoreBest, gameAreaWidth / 2, gameAreaHeight - 30);

	//Controlls
	fill(255, 0, 100);
	rect(0, gameAreaHeight, gameAreaWidth, controlsAreaHeight);
	fill(0, 0, 0);
	rect(controlsX, controlsY, controlButtonSize, controlButtonSize);											//Up
	rect(controlsX, controlsY + controlButtonSize * 2, controlButtonSize, controlButtonSize);					//Down
	rect(controlsX - controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize);	//Left
	rect(controlsX + controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize);	//Right
}

function pickLocation()
{
	let colums = floor(gameAreaWidth / gridSize);
	let rows = floor(gameAreaHeight / gridSize);
	food = createVector(floor(random(colums)), floor(random(rows)));
	food.mult(gridSize);
}


function touchStarted() 
{
	//Up
	if(IsWithinSquare(controlsX, controlsY, controlButtonSize, controlButtonSize))
	{
		snake.Direction(0, -1);
	}

	//Down
	if(IsWithinSquare(controlsX, controlsY + (controlButtonSize * 2), controlButtonSize, controlButtonSize))
	{
		snake.Direction(0, 1);
	}

	//Left
	if(IsWithinSquare(controlsX - controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize))
	{
		snake.Direction(-1, 0);
	}

	//Right
	if(IsWithinSquare(controlsX + controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize))
	{
		snake.Direction(1, 0);
	}
}

function keyPressed()
{
	if(keyCode === UP_ARROW)
	{
		snake.Direction(0, -1);
	}
	else if(keyCode === DOWN_ARROW)
	{
		snake.Direction(0, 1);
	}
	else if(keyCode === RIGHT_ARROW)
	{
		snake.Direction(1, 0);
	}
	else if(keyCode === LEFT_ARROW)
	{
		snake.Direction(-1, 0);
	}
}

function IsWithinSquare(x, y , width, height)
{
	if(mouseX > x && mouseX < (x + width))
	{
		if(mouseY > y && mouseY < (y + height))
		{
			return true;
		}
	}
	
	return false;
}

