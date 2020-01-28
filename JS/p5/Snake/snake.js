function Snake()
{
    this.x = 0;
    this.y = 0;
    this.xSpeed = 1;
    this.ySpeed = 0;
    this.total = 0;
    this.tail = [];

    this.Direction = function(x, y)
    {
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
            return true;
        }
        else
        {
            return false;
        }
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

        this.x = constrain(this.x, 0, width - gridSize);
        this.y = constrain(this.y, 0, height - gridSize);
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