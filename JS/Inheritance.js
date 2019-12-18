//Base class
class Vehicle
{
    constructor()
    {
        this.type = "car";
    }

    start()
    {
        return `Starting: ${this.type}`;
    }
}

//Car class based on the Vehicle class
class Car extends Vehicle 
{
    start()
    {
        //Super is used to reference the base class
        return "In car start - " + super.start();
    }
}

let car = new Car();
console.log(car.start());                               //Output: In car start - Starting: car
