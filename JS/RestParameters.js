//Is the rest of the parameters
//The Rest Parameter needs to be last


function sendCars(day, ...carIds)
{
    carIds.forEach(id => console.log(id));
}
sendCars("Monday", 1, 2, 3);                        //Returns 1,2,3


function sendCars(...carIds, day)
{
    carIds.forEach(id => console.log(id));
}
sendCars("Monday", 1, 2, 3);                        //Error - Rest element must be last element