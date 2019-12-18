class Car
{
    constructor(id)
    {
        this.id = id;
    }

    identify()
    {
        return `Car id: ${this.id}`;
    }

    identifyExtended(suffix)
    {
        return `Car id: ${this.id}${suffix}`;
    }
}

let car = new Car(123);

console.log(car);                                   //Output: Car {id: 123}
car.id = 456;
console.log(car);                                   //Output: Car {id: 456}

console.log(car.identify());                        //Output: Car id: 456
console.log(car.identifyExtended("!!!"));           //Output: Car id: 456!!!

