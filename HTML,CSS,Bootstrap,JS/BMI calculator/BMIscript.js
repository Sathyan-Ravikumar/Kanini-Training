
function BMIclaculator(){
    
    var h=document.querySelector('#height').value;
    var w=document.querySelector('#weight').value;

    let BMI=w/((h/100)*(h/100));
     BMI=BMI.toFixed(2);

    document.getElementById("result").innerHTML=BMI;

    if(h==''||w=='')
    {
        alert("please enter the inputs");
    }

    if(BMI < 18.5)
    {
        document.getElementById("comment").innerHTML="Comment : Underweight";
    }
    if(BMI >=18.5 && BMI<25)
    {
        document.getElementById("comment").innerHTML="Comment : healthy";
    }
    if(BMI >=25 && BMI <30)
    {
        document.getElementById("comment").innerHTML="Comment : Overweight";
    }
    if (BMI > 30)
    {
        document.getElementById("comment").innerHTML="Comment : Obesity";
    }
    
}