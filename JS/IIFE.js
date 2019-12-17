//   I           I       F        E
//An Immediately-invoked Function Expression is a way to execute functions immediately, as soon as they are created. 
//IIFEs are very useful because they don't pollute the global object, and they are a simple way to isolate variables declarations


//Simple example
let app = (function() 
{
    let carId = 123;
    console.log("in function");
    return {};
})();

console.log(app);


//With Closure
let app = (function() 
{
    let carId = 123;

    let getId = function()
    {
        return carId;
    };

    return
    {
        getId: getId;
    };
})();

console.log(app.getId);
//Note: This should work accordingly to pluralsight, but it dosen't...
