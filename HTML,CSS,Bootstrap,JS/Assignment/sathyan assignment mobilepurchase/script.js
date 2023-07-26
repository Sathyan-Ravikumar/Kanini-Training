function validateName(){
    let name = document.getElementById("name").value;
    let validation=/[a-zA-Z]+[a-z A-Z]*/g;

    if (validation.test(name)){
        validateNumber();
    }
    else{
        document.getElementById("result").innerHTML="Enter Valid Name";
    }


}
function validateNumber(){
    let number = document.getElementById("phoneNumber").value
    var validation = /[0-9]{10}/g;

    if (validation.test(number)){
        validateMail();
    }
    else{
        document.getElementById("result").innerHTML="Enter Valid Number"
    }
}
function validateMail(){
    let mail = document.getElementById("emailId").value
    var validation= /^[a-z0-9]+@[a-z]+\.[a-z]/g;

    if (validation.test(mail)){
        validateAddress()
    }
    else{
        document.getElementById("result").innerHTML="Enter Valid email"
    }
}


function validateAddress() {
        var entered_address = document.getElementById("address").value;
        if (entered_address == "") {
          document.getElementById("result").innerHTML =
            "Please enter Address";
        } else {
          calculation()
        }
      }

function calculation(){

    let check1=document.getElementById("option1").checked
    let check2=document.getElementById("option2").checked
    let check3=document.getElementById("option3").checked
    let check4=document.getElementById("option4").checked
    let check5=document.getElementById("option5").checked
    let total=0;

    if (check1){
        total=total+799
    }
    if (check2){
        total=total+899
    }
    if (check3){
        total=total+1199
    }
    if (check4){
        total=total+299
    }
    if (check5){
        total=total+999
    }

    if (total===0){
        document.getElementById("result").innerHTML="No selection has been made";
    }
    else if (total>=2000){
        var discount=(total *20)/100;
        var disc_total=total-discount;
        document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
                  Math.round(disc_total) +" on delivery.";
    }
    else {
        document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
                  Math.round(total) + " on delivery."
    }
}
























// function validateName() {
//     var entered_name = document.getElementById("name").value;
//     var regName = /[A-Za-z\s]+$/g;
  
//     if(regName.test(entered_name))
//     {
//   validateContactNo();
  
//     }
//     else
//     {
//       document.getElementById("result").innerHTML =
//         "Please enter valid name";
//     }
    
//   }
  
//   function validateContactNo() {
//     var re = /^\d{10}$/g;
//     var entered_phnumber = document.getElementById("phoneNumber").value;
  
//     if(re.test(entered_phnumber))
//     {
//       emailValidation();
//     }
//     else
//     {
//       document.getElementById("result").innerHTML =
//         "Please enter valid phone number";
//     }
   
//   }
  
//   function emailValidation() {
//     var entered_email = document.getElementById("emailId").value;
//     var validRegex =
//       /^[a-zA-Z0-9]+@[a-zA-Z0-9.]+/g;
//       if(validRegex.test(entered_email))
//       {
//         costCalculation();
//       }
//       else
//       {
//         document.getElementById("result").innerHTML =
//         "Please enter valid emailid";
//       }
    
//   }
  
//   function validateAddress() {
//     var entered_address = document.getElementById("address");
//     if (entered_address.value == "") {
//       entered_address.classList.remove("valid");
//       entered_address.classList.add("invalid");
//       document.getElementById("result").innerHTML =
//         "Please enter valid Credentials";
//       entered_address.focus();
//     } else {
//       entered_address.classList.remove("invalid");
//       entered_address.classList.add("valid");
//     }
//   }
  
//   var comboPrices = {
//     option1: 799,
//     option2: 899,
//     option3: 1199,
//     option4: 299,
//     option5: 999,
//   };
  
//   function costCalculation() {
     
//     var checkCombo1 = document.getElementById("option1").checked;
//     var checkCombo2 = document.getElementById("option2").checked;
//     var checkCombo3 = document.getElementById("option3").checked;
//     var checkCombo4 = document.getElementById("option4").checked;
//     var checkCombo5 = document.getElementById("option5").checked;
//     var originalPrice = 0;
//     if (checkCombo1 || checkCombo2 || checkCombo3 || checkCombo4 || checkCombo5) {
//       if (checkCombo1) {
//         originalPrice += comboPrices.option1;
//       }
//       if (checkCombo2) {
//         originalPrice += comboPrices.option2;
//       }
//       if (checkCombo3) {
//         originalPrice += comboPrices.option3;
//       }
//       if (checkCombo4) {
//         originalPrice += comboPrices.option4;
//       }
//       if (checkCombo5) {
//         originalPrice += comboPrices.option5;
//       }
//       if (originalPrice >= 2000) {
//         var discount = (originalPrice * 20) / 100;
//         var netPrice = originalPrice - discount;
//         document.getElementById("result").innerHTML =
//           "Order has been placed successfully. You are requested to pay Rs." +
//           Math.round(netPrice) +
//           " on delivery.";
//       } 
//       else {
//         document.getElementById("result").innerHTML =
//           "Order has been placed successfully. You are requested to pay Rs." +
//           Math.round(originalPrice) +
//           " on delivery.";
//       }
//     } else {
//       document.getElementById("result").innerHTML = "No selection has been made.";
//     }
//   }