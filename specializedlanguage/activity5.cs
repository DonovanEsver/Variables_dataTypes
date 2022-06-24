using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    //Delcare The Values
      int yourFriends;
      int totalFriends;
      
    
      
      
      //assign
        yourFriends = 200;
        //I had to make this equal 200 because get next input exist on coral but not C#
        totalFriends = yourFriends * yourFriends;
        
        
      
      
      
      
      
      //Output
      Console.WriteLine("Your friends know ");
      Console.WriteLine(totalFriends);
      
      Console.WriteLine(" people.");
      
      //assign
      totalFriends = totalFriends * yourFriends;
       
       //Output
       Console.WriteLine("and, They know ");
       Console.WriteLine(totalFriends);
       Console.WriteLine(" people.");
       

     }
  }
}
