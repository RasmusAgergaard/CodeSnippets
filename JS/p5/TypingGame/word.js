function Word()
{
    let allTheWords = ["dent", "outage", "zoom", "cash", "cool", "roar", "drink", "praise", "seat", "orbit", "switch", "sync", "adopt", "lean", "trend", "buggy", "shine", "case", "scent", "riser", "tint", "acting", "reside", "reign", "hunk", "sport", "naked", "judge", "narrow", "wail", "study", "plug", "spear", "wipe", "essay", "furry", "jet", "polyp", "rid", "tether"];
    let index = floor(random(allTheWords.length));
    this.content = allTheWords[index];

    this.x = random(0 + 40, canvasWidth - 40);
    this.y = 0;
    this.speed = random(0.1, 1);

    let size = random(20, 36);

    this.Update = function()
    {
        this.y += this.speed;
    }

    this.Show = function()
    {
        //BG
        fill(255, 0, 100);
        circle(this.x, this.y, 60)

        //Text
        textSize(size);
		fill(255, 255, 255);
		text(this.content, this.x, this.y);
    }
}