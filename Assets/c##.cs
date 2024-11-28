using UnityEngine;

public class PrintName : MonoBehaviour
{
    void Start()
    {
/*
Excercise 1: Provide the result of the following logical operators (no need to write the code)

true && true                  ==> truenbv

true && false                 ==> false 

false && false                ==> false 

true || false                     ==> true 

false || false                    ==> false 

!true                               ==> false

!(false || true)                  ==> false

(5 > 3) && (2 < 4)           ==> true && true ==> true

(10 == 10) || (5 != 5)       ==> true || false ==> true

(3 >= 2) && !(6 < 3)       ==> true && false  ==>false


Exercise 2: Provide the result of the following (Operator Precedence). No need to write the code.

(5 + 3) * 2 - 4 / 2                                               ==>(8)*2-2  ==>16-2 ==>14

10 - 3 * 2 + 4                                                     ==>10-6+4 ==>4+4 ==>8

2 + 3 * 4 > 10 && 4 <= 4                                 ==>2+12>10 && true ==> true && true ==>true 

!(10 >= 5) || 7 != 3                                             ==> !(true) || true ==> false || true ==> true

(8 % 3 + 2) * 4 - 6                                              ==> (2+2) * 4 - 6 ==> 16-6==> 10

10 == 5 + 5 && 4 > 2 || 3 < 1                           ==> 10 ==10 && true || false  ==> true && true ==> true

++x * 2 - --y / 2 (Assume x = 3 and y = 5)        ==>(1 + 3 ) * 2 - (1 - 5) / 2 ==> 4 * 2 - 4 /2 ==> 8 -2 ==> 6

(4 + 5 * 2) != 13 || (6 / 2 == 3)                           ==> ( 4 + 10 ) != 13 || ( 3 == 3) ==> 14 !=13 ||  true ==> true || true ==> true

6 >= 3 * 2 && (5 % 2 == 1)                              ==> 6 >= 6 && ( 1 == 1 )  ==>  true  && true ==> true 


/*/

int v  = 0;
while(v<4) {
    if(v == 0){
        Debug.Log("Game Over");
    }
   if(v==1){
        Debug.Log("The last life");
    }
    if(v==3){Debug.Log("Many lives") ;
    }
    v++;

}

    }
}