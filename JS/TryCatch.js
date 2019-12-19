//The try/catch handles the error and the program continue to run
//The finally alwas runs

try 
{
    let car = newCar; //Error
} 
catch (error) 
{
    console.log("Error: " + error);
}
finally 
{
    console.log("This alwas executes");
}

console.log("Continuing...");


//Custom error 
try 
{
    //Code here...
    throw new Error("My custom error");
} 
catch (error) 
{
    console.log("Error: " + error);                     //Output: Error: Error: My custom error
}
finally //Alwas runs
{
    console.log("This alwas executes");
}