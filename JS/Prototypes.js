//Prototype saves memory, as the pototype function only get created once, and not one per object

//Constructor function
function Car(id)
{
    this.carId = id;
}

//Prototype
Car.prototype.start = function()
{
    console.log("Start: " + this.carId);
};

let vehicle = new Car(123);
vehicle.start();