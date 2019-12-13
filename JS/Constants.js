//Used to avoid programmer errors. If a value shouldn't change, it should be a constant

const carId;            //Error - Needs to be initialized

const carId = 100;      //This is correct

carId = 30;             //Error - The value can't be changed after initialization