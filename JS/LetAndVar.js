//Let has block scoping
//Var does not
//It's best practice to use let over var, as it lets you catch errors earlier


console.log(car1);
var car1 = 100;             //Return undefined


console.log(car2);          //Should return error, but returns undefined
let car2 = 100;


if(true)
{
    let car3 = 200;
}
console.log(car3);          //Error - Not defined, as let is block scoped


if(true)
{
    var car4 = 200;
}
console.log(car4);          //Returns 200