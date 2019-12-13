//Opposite of the Rest Parameter, the Spread Parameter, takes the array and spreads it out the the different parameters


function startCars(car1, car2, car3)
{
    console.log(car1, car2, car3);
}
let carIds = [1, 2, 3];
startCars(...carIds);                               //Outputs 1 2 3


//Combined with the Rest parameter
function startCars(car1, car2, car3, ...theRest)
{
    console.log(theRest);
}
let carIds = [1, 2, 3, 4, 5, 6];
startCars(...carIds);                               //Outputs [4, 5, 6]
