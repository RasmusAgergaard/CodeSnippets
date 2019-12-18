//Convert to JSON
let car =
{
    id: 123,
    style: "convertible"
};
console.log(JSON.stringify(car));               //Output {"id":123,"style":"convertible"}


//Parse
let jsonIn =
`
    [
        {"carId" : 123},
        {"carId" : 456},
        {"carId" : 789}
    ]    
`;

let carIds = JSON.parse(jsonIn);
console.log(carIds);                            //Output [{…}, {…}, {…}]
                                                //0: {carId: 123}
                                                //1: {carId: 456}
                                                //2: {carId: 789}