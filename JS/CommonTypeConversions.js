

let number = 1234;
console.log(typeof(number));                            //Output number
number = number.toString(); //convert to string
console.log(typeof(number));                            //Output string

console.log(Number.parseInt("52"));                     //Output 52
console.log(typeof(Number.parseInt("52")));             //Output number
console.log(Number.parseInt("52ABC"));                  //Output 52 - It only parses the numbers, untill it his something that cannot be converted

console.log(Number.parseFloat("52.42"));                //Output 52.42