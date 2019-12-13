//Use {}, because it's objects, instead of [] as arrays


let car = {id: 5000, style: "convertible"};
let {id, style} = car;
console.log(id, style);                                     //Returns 5000 convertible


let car = {id: 5000, style: "convertible"};
let id, style;
{id, style} = car;
console.log(id, style);                                     //Error - the brackets confuses the compiler, as it's also used for code blocks


let car = {id: 5000, style: "convertible"};
let id, style;
({id, style} = car); //Use () to surround the brackets
console.log(id, style);                                     //Returns 5000 convertible

