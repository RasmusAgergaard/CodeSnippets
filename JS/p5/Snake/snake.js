function Snake()
{
    this.x = 0;
    this.y = 0;
    this.xSpeed = 0;
    this.ySpeed = -1;
    this.total = 0;
    this.tail = [];

    this.Direction = function(x, y)
    {
        if(this.xSpeed === -1 && x === 1)
        {
            return false;
        }

        if(this.xSpeed === 1 && x === -1)
        {
            return false;
        }

        if(this.ySpeed === -1 && y === 1)
        {
            return false;
        }

        if(this.ySpeed === 1 && y === -1)
        {
            return false;
        }

        this.xSpeed = x;
        this.ySpeed = y;
    }

    this.Death = function()
    {
        for(let i = 0; i < this.tail.length; i++)
        {
            let position = this.tail[i];
            let distanceToTail = dist(this.x, this.y, position.x, position.y);

            if(distanceToTail === 0)
            {
                console.log("Sarting over");
                this.total = 0;
                this.tail = [];
                scoreCurrent = 0;
                this.ResetPosition();
                this.xSpeed = 0;
                this.ySpeed = -1;

                //Death screen
                fill(255, 0, 100);
	            rect(0, 0, gameAreaWidth, gameAreaHeight);
            }
        }
    }

    this.Eat = function(position)
    {
        let distance = dist(this.x, this.y, position.x, position.y);

        if(distance < 1)
        {
            this.total++;
            scoreCurrent++;

            if(scoreBest < scoreCurrent)
            {
                scoreBest = scoreCurrent;
            }

            return true;
        }
        else
        {
            return false;
        }
    }

    this.ResetPosition = function()
    {
        let midtColum = (floor(gameAreaWidth / gridSize)) / 2;
        let midtRow = (floor(gameAreaHeight / gridSize)) / 2;

        this.x = midtColum * gridSize;
        this.y = midtRow * gridSize;;
    }

    this.Update = function()
    {
        if(this.total === this.tail.length)
        {
            //The elements of the tail shifts down in the array
            for(let i = 0; i < this.tail.length - 1; i++)
            {
                this.tail[i] = this.tail[i + 1];
            }
        }

        this.tail[this.total - 1] = createVector(this.x, this.y);

        this.x = this.x + this.xSpeed * gridSize;
        this.y = this.y + this.ySpeed * gridSize;

        this.x = constrain(this.x, 0, gameAreaWidth - gridSize);
        this.y = constrain(this.y, 0, gameAreaHeight - gridSize);
    }

    this.Show = function()
    {
        fill(255);
        
        for(let i = 0; i < this.tail.length; i++)
        {
            rect(this.tail[i].x, this.tail[i].y, gridSize, gridSize);
        }

        rect(this.x, this.y, gridSize, gridSize);
    }
}