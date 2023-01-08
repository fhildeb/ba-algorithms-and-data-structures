package SearchAlgorithms;

import java.io.IOException;

public class Main
{
   
   public static void main(String[] args) throws IOException
   {
      String[] strings =
      {
         "Affe", "Banane", "Charme", "Dummkopf", "Edelschimmel", "Fehlertoleranz", "Gabel"
      };
      
      System.out.println(SearchAlgorithms.naiveSearch(strings, "Charme"));
      System.out.println(SearchAlgorithms.binarySearch(strings, "Charme"));
      System.out.println("-");
      
      System.out.println(SearchAlgorithms.naiveSearch(strings, "Fehlertoleranz"));
      System.out.println(SearchAlgorithms.binarySearch(strings, "Fehlertoleranz"));
      System.out.println("-");
      
//      SearchBenchmark.run(strings, false);
//      SearchBenchmark.run(50, false);
//      SearchBenchmark.run(1000, false);
   }
}

