
//Runs untill canceled
let intervalId = setInterval(function()
{
    console.log("1 sec has passed");
}, 1000);


//Runs once
let timeoutId = setTimeout(function()
{
    console.log("3 sec has passed");
}, 3000);


//Can be cleared like this
clearInterval(intervalId);
clearTimeout (timeoutId);