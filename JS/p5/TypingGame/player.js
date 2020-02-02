function Player()
{
    this.playerString = "";
    this.x = canvasWidth / 2;
    this.y = canvasHeight - 30;
    this.speed;
    this.kills = 0;

    let typeBoxWidth = canvasWidth / 4;
    let typeBoxHeight = 50;

    this.Show = function()
    {
        //Player square
        fill(255, 255, 255);
        rect(this.x - (typeBoxWidth / 2), this.y - 30, canvasWidth / 4, typeBoxHeight, 5);

        //Player text
        textSize(40);
        fill(0, 0, 0);
        text(this.playerString, this.x, this.y);

        //Kills
        textSize(40);
        fill(255, 255, 255);
        text(this.kills, this.x, this.y - 50);
    }

    this.ResetPlayerString = function()
    {
        this.playerString = "";
    }
    
    this.AddKill = function()
    {
        this.kills++;
    }
}