//              *  ** ***
// let getId = ( ) => 123;
// *   parameters
// **  arrow symbol
// *** return value

let getId = () => 123;
console.log(getId());                                               //Output 123

let getId = (prefix, suffix) => prefix + 450 + suffix;
console.log(getId("Price: ", "DKK"));                               //Output Price: 450DKK

//The same as above, but with a function body
let getId = (prefix, suffix) => 
{
    return prefix + 450 + suffix; //Now we need the return keyword
};
console.log(getId("Price: ", "DKK"));                               //Output Price: 450DKK