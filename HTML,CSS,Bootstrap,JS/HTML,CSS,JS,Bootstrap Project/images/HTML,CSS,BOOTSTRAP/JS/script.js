function f1()
{
    document.getElementById("para1").innerHTML="Welcome";
}
function f2()
{
    console.log("hello");
}
function f3()
{
    var x=10,y=4;
    document.getElementById("para3").innerHTML=x+y;
    {
        let x=10,y="hello";
        document.getElementById("para2").innerHTML=x+y;
    }
}
function f4()
{
    var x="hi",y=10,z=6;
    document.getElementById("para4").innerHTML=x+y+z;
}

function f5()
{
    var x="hi",y=10,z=null;
    document.getElementById("para5").innerHTML=x+y+z;
}

function f6()
{
    var x,y=4,z=null;
    document.getElementById("para6").innerHTML=x+y;
    {
        document.getElementById("para7").innerHTML=y*z;
    }
}

//js bidint can save 30digits

function functions(x,y)
{
    document.getElementById("para8").innerHTML=x+y+z;
    {
        document.getElementById("para9").innerHTML=y*x;
    }
}
// if the unknown var is use the js does not work

function f7()
{
    const stud={rno:100,name:'AAAA',address:'13,pejfaakfk'} //object
    document.getElementById("para10").innerHTML=stud.rno + '  ' + stud.name;       //here stud is the object.
    stud.name='BBB';                                                               // changing the attribute of the obj
    document.getElementById("para11").innerHTML=stud.rno + '      ' + stud.name;
    stud={gender:'male'}                                                           // trying to add a new attribute using same obj with const.but it does not work because of const
    document.getElementById("para12").innerHTML=stud.gender;

}

function f8(){                  //array
    number=[10,20,30];
    alert(number[2]);
    number[3]=40;
    alert(number[3]);
    number[5]=60;
    alert(number[5]);
    alert(number[4]);
    alert(number);
    number=[];
    alert(number);
    
    numbers=new Array[1,2,3,4];   //other way to get a array.it is faster than objects.
}

// regEx
function regex(){
    let pattern ="hi iam sathyan";
    let input ="sat";
    alert(pattern.search(input));  //search returns the position.
}
function regex(){
    let pattern =/[A-z]+[a-z]+[0-9]/;
    
}