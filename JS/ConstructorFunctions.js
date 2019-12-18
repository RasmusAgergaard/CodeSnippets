//Constructor function
function Car(id)
{
    this.carId = id;

    this.start = function()
    {
        console.log("Start: " + this.carId); //Remember to always use 'this' to access the propperties
    };
}

//You haft to create a new object like this, and not just call the function like a normal function
let vehicle = new Car(123);
vehicle.start();
