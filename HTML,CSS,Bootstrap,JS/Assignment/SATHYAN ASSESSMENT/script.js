



document.getElementById("submit").addEventListener('click',bookAppointment);
var name_pattern = /[a-zA-Z]+[a-z A-Z]*/g
var phone_pattern = /[789]\d{9}/g
var email_pattern = /[^@]+\@[a-z]+\.[a-z]+/g 


function bookAppointment(){
    let checked = document.getElementById("yearlyMaintenance");
    let customerName = document.getElementById("customerName").value;
    let acType = document.getElementById("acType").value;
    let serviceType = document.getElementById("serviceType").value;
    let email = document.getElementById("email").value;
    let phone = document.getElementById("mobileNumber").value;
    let result = document.getElementById("result");
    let serviceCharge = 0;
    
    switch (serviceType)
    {
        case 'Cleaning':
            serviceCharge = 500;
            break;
        case 'Repair':
            serviceCharge = 1000;
            break;
        case 'Gas Refill':
            serviceCharge = 1500;
            break;
        default:
            serviceCharge = 0;
    }


    if(customerName.match(name_pattern) &&  email.match(email_pattern) && phone.match(phone_pattern) && checked.checked ){
        result.innerHTML = `Hello ${customerName}, your service appointment for ${acType} AC
        ${serviceType} with yearly maintenance will be send to your email ID
        ${email} and the estimated service charge will be Rs ${serviceCharge + 1000}`;
    }else if(checked.checked != "true" && email.match(email_pattern) &&  serviceType.length > 0 && customerName.match(name_pattern)){
        result.innerHTML = `Hello ${customerName}, your service appointment for ${acType} AC
        ${serviceType} without yearly maintenance will be send to your email ID
        ${email} and the estimated service charge will be Rs ${serviceCharge}`;
    }else{
        result.innerHTML = "please enter the details correctly";
    }
    console.log(checked.checked);
}

