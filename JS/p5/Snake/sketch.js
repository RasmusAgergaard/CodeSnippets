let gameAreaWidth = window.innerWidth;
let gameAreaHeight = gameAreaWidth;
let controlsAreaHeight = gameAreaHeight / 2;
let controlButtonSize = 50;
let controlsX = gameAreaWidth / 2 - (controlButtonSize / 2);
let controlsY = gameAreaHeight + 15;
let gridSize = 20;
let snake;
let food;

function setup() 
{
	frameRate(8);
	createCanvas(gameAreaWidth, gameAreaHeight + controlsAreaHeight);

	snake = new Snake();
	pickLocation();
}

function draw() 
{
	background(51);

	//Snake
	snake.Death();
	snake.Update();
	snake.Show();

	//Controlls
	fill(255, 0, 100);
	rect(0, gameAreaHeight, gameAreaWidth, controlsAreaHeight);
	fill(0, 0, 0);
	rect(controlsX, controlsY, controlButtonSize, controlButtonSize);											//Up
	rect(controlsX, controlsY + controlButtonSize * 2, controlButtonSize, controlButtonSize);					//Down
	rect(controlsX - controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize);	//Left
	rect(controlsX + controlButtonSize, controlsY + controlButtonSize, controlButtonSize, controlButtonSize);	//Right

	//Food
	if(snake.Eat(food))
	{
		pickLocation();
	}

	fill(255, 0, 100);
	rect(food.x, food.y, gridSize, gridSize);
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
	if(mouseX > controlsX && mouseX < controlsX + controlButtonSize && mouseY > controlsY && mouseY < controlsY + controlButtonSize)
	{
		snake.Direction(0, -1);
		ellipse(mouseX, mouseY, 50, 50);
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

