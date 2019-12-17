let o = 
{
    carId: 123,
    getId: function()
    {
        console.log(this);                          //Output {carId: 123, getId: ƒ}
        return this.carId;
    }
};
console.log(o.getId());                             //Output 123


//Apply
let o = 
{
    carId: 123,
    getId: function(prefix)
    {
        return prefix + this.carId;
    }
};
let newCar = {carId: 456};
console.log(o.getId.apply(newCar, ["ID: "]));       //Output 456


//Bind - Makes a copy of the function
let o = 
{
    carId: 123,
    getId: function()
    {
        return this.carId;
    }
};

let newCar = {carId: 456};

let newFn = o.getId.bind(newCar);

console.log(newFn());                               //Output 456