let form = document.getElementById("user-form");

form.addEventListener("submit", event => 
{
    let user = form.elements["user"];
    let userError = document.getElementById("user-error");
    let avatar = form.elements["avatar-file"];

    if (user.value < 4)
    {
        userError.textContent = "Invalid entry";
        userError.style.color = "red";
        user.style.borderColor = "red";
    
        user.focus();
    }

    //Log input
    console.log(user.value + " " + avatar.value);

    //Prevent posting
    event.preventDefault();
});