function validation(){
   var name=document.getElementById("name").value;
   var pattern_name=/^[a-zA-Z]+[ a-zA-Z]*/g;

   var mail=document.getElementById("Email").value;
   var pattern_mail=/^[a-zA-Z0-9 .]+@[a-zA-Z]+(.[a-zA-Z0-9])*$/g;

   var num=document.getElementById("number").value;
   var pattern_num=/^[6-9]{1}[0-9]{9}$/g;

   var ques=document.getElementById("question").value;

   var fup = document.getElementById("myFile");
   var fileName = fup.value;
   var ext = fileName.substring(fileName.lastIndexOf('.') + 1);
   var count=0;

   if(name!=''||pattern_name.test(name)){
    document.getElementById("name").innerHTML="";
    count++;
   }
   if(name==''||!pattern_name.test(name)){
    alert('Please enter your name properly');
   }

   if(mail!=''||pattern_mail.test(mail)){
    document.getElementById("Email").innerHTML="";
    count++;
   }
   if(mail==''||!pattern_mail.test(mail)){
    alert('Please enter your mail correctly');
   }

   if(num!=''||pattern_num.test(num)){
    document.getElementById("number").innerHTML="";
    count++;
   }
   if(num==''||!pattern_num.test(num)){
    alert('Please enter your number correctly');
   }

   if(ques!='')
   {
    document.getElementById("question").innerHTML="";
    count++;
   }
   else{
    alert('Enter your question');
   }

   if(ext =="jpg" || ext=="jpeg" || ext=="png") {
    count++;
    } else {
    alert("Upload jpg/jpeg/png Images only");
    }

    if(count==5){
        alert('Your message is sent');
        document.getElementById("link").href="landing.html"; 
    }
    else{
        alert('Please refill the form');
    }
}