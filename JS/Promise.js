
let promise = new Promise
(
    function(resolve, reject)
    {
        setTimeout(resolve, 3000, "Some value");
    }
);

console.log(promise);                               //Goes from "pending" to "resolved"

//We need to catch the promise 
promise.then
(
    value => console.log("Fulfilled: " + value),
    error => console.log("Error: " + error)
);