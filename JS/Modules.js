//models/car.js
export class Car
{
    constructor(id)
    {
        this.id = id;
    }
}


//index.js
import {Car} from "./models/car.js";

let car = new Car(123);
console.log(car);                           //Output: Car {id: 123}