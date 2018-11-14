using System;


public class RandomState{
    public readonly Random getrandom = new Random(123);
    public RandomState (){

    }
    public int getNext (int min, int max){
        return getrandom.Next(min, max);
    }
}
