package Matrix;

public class Semimagic_Square {
    public static boolean requals(Matrix n)
    {
        int[] summe = n.getRowSums();
        int start = 0;
        if(summe.length > 0)
        {
            start = summe[0];

        }
        for (int i = 0; i < summe.length ; i++)
            if(summe[i] != start)
                return false;
        return true;

    }

    public static boolean cequals(Matrix n)
    {
        int[] summe = n.getColSums();
        int start = 0;
        if(summe.length > 0)
        {
            start = summe[0];
        }
        for(int i = 0; i < summe.length; i++)
            if(summe[i] != start)
                return false;
        return true;
    }

    public static void main(String[] args)
    {
        Matrix n = new Matrix(4,4);
        n.setValuesLineByLine(16,3,2,13,5,10,11,8,9,6,7,12,4,15,14,1);
        System.out.println(n);
        if(requals(n) && cequals(n))
            System.out.println("It is a semimagic square matrix.");
        else
            System.out.println("It is not a semimagic square matrix.");

    }
}

