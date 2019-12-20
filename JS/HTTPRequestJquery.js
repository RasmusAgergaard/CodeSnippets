import $ from "jQuery";

let promise = $.get("url here");

promise.then
(
    data => console.log("Success: ", data),
    error => console.log("Error: ", error)
);