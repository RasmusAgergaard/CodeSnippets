//Taking the array and assigning it to variables


let carIds = [100, 200, 300];
let [car1, car2] = carIds;
console.log(car1, car2);                        //Returns 100 200


let carIds = [100, 200, 300, 400];
let [car1, car2, ...theRest] = carIds;
console.log(car1, car2, theRest);               //Returns 100 200 [300, 400]


let carIds = [100, 200, 300, 400];
let car1, car2, theRest;
[car1, car2, ...theRest] = carIds; //Destructuring on a seperate line
console.log(car1, car2, theRest);               //Returns 100 200 [300, 400]