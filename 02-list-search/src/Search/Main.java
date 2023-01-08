package Search;

import java.io.IOException;

public class Main
{
   
   public static void main(String[] args) throws IOException
   {
      String[] strings =
      {
         "Ape", "Banana", "Charm", "Fool", "Noble", "Fault", "Fork"
      };
      
      System.out.println("3rd Array Test");
      System.out.println("Naive Search:");
      System.out.println(SearchAlgorithms.naiveSearch(strings, "Charme"));
      System.out.println("Binary Search:");
      System.out.println(SearchAlgorithms.binarySearch(strings, "Charme"));
      System.out.println("-");
      
      System.out.println("");
      System.out.println("6th Array Test");
      System.out.println("Naive Search:");
      System.out.println(SearchAlgorithms.naiveSearch(strings, "Fehlertoleranz"));
      System.out.println("Binary Search:");
      System.out.println(SearchAlgorithms.binarySearch(strings, "Fehlertoleranz"));
      System.out.println("-");
   }
}

