//Equality Operators
if (var1 == var2) { }       //Will atemp to typecast the variables to be the same type
if (var1 === var2) { }      //"Strict equality operator" - This is best practice

if (var1 != var2) { }       //Again - will try to use type conversion
if (var1 !== var2) { }      //No type conversion


//Unary Operators
++var1                      //Increment the value BEFORE it is used
var1++                      //Increment the value AFTER it is used
--var1                      
var1--                      
+var1                       //Not used often, but can convert a string into a numeric type
-var1                       //Changes the sign of a numeric variable (If it was 5, it is now -5)


//Logical Operators
&&                          //AND (Has a higher presidens than OR)
||                          //OR
!var1                       //Will convert the variable into a bool, and then flip it

let userSettings = null;                        //Another way to use || - This will test the first parameter, and then fall back to the other one if it is false
let defaultSettings = {name: "Default"};
console.log(userSettings || defaultSettings);   //Output {name: "Default"}


//Conditional Operator
var result = (foo > 5) ? true : false;

console.log((5 > 4) ? "Yes" : "No");            //Output Yes


//Assignment Operators
var1 += 10;                                     //var1 = var1 + 10
var1 -= 10;                                     //var1 = var1 - 10
var1 /= 10;                                     //var1 = var1 / 10
var1 *= 10;                                     //var1 = var1 * 10
var1 %= 10;                                     //var1 = var1 % 10


//Operator precedence
//Look at developer.mozilla.org for the Operator precedence table