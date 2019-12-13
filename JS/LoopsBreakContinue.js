//Break and continue are valuable, but should be used as little as possible


//This is legal, 'i' can be declared outside the loop
let i = 0;
for(; i < 5; i++)
{
    console.log(i);                                         //Output 0 1 2 3 4
}


//Break - Will exit the loop, and not run through the rest
for (let i = 0; i < 5; i++) 
{
    console.log(i);                                         //Output 0 1 2                

    if (i === 2) 
    {
        break;
    }
}


//Continue - Will skip the single iteration, but will continue to run the rest of the loop
for (let i = 0; i < 5; i++) 
{
    if (i === 2) 
    {
        continue;
    }

    console.log(i);                                         //Output 0 1 3 4
}