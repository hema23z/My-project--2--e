using UnityEngine;

public class PrintName : MonoBehaviour
{
    void Start()
    {
    //Exercise 1: Number Generator: 

        int num= 0;
        while(num<21)
        {
         int  rand=Random.Range(1,21);
         Debug.Log(num);
            Debug.Log(rand);
        num++;
         if(rand==5)
        continue;
        if(rand==15)
        break;

        }

    //Exercise 2: Funny Sentence Generator: 
           string [ ] fan={ "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
           int numFan=0;
        while(numFan<7){
        string wored1= fan[Random.Range(0,fan.Length)];
           Debug.Log( wored1);
       numFan++;
      

        }

        /*
                  كنت اريد الكلمات في جملة واحدة لم اتسطيع استعنت بالذكاء الاصطناعي  
                  
          string[] fan = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int numFan = 0;
        string sentence = "";
        while (numFan < 7)
        {
            string word = fan[Random.Range(0, fan.Length)];
             sentence += word + " ";
                  numFan++;
        }
        Debug.Log("Funny Sentence: " + sentence.Trim());
       /*/
      
    }
}
