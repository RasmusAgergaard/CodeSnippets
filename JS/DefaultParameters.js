let trackCar = function(carId, city = "NY")
{
    console.log(`Tracking ${carId} in ${city}`);
};
console.log(trackCar(123));                                 //Output Tracking 123 in NY
console.log(trackCar(123, "Chicago"));                      //Output Tracking 123 in Chicago