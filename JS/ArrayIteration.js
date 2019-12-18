let carIds = 
[
    {carId: 123, style: "sedan"},
    {carId: 456, style: "convertible"},
    {carId: 789, style: "sedan"}
];

//ForEach
carIds.forEach(car => console.log(car));                                //Output {carId: 123, style: "sedan"} {carId: 456, style: "convertible"} {carId: 789, style: "sedan"}
carIds.forEach((car, index) => console.log(car, index));                //Output {carId: 123, style: "sedan"} 0 {carId: 456, style: "convertible"} 1 {carId: 789, style: "sedan"} 2

//Filter
let convertibles = carIds.filter(car => car.style === "convertible");
console.log(convertibles);                                              //Output {carId: 456, style: "convertible"}

//Every - True or false based on the entire array
let result = carIds.every(car => car.carId > 0);
console.log(result);                                                    //Output true

//Find - Returns the fist item that fits the condition
let car = carIds.find(car => car.carId > 500);
console.log(car);                                                       //Output {carId: 789, style: "sedan"}