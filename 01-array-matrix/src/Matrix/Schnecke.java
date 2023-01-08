package Matrix;

public class Schnecke {

    public static void main(String[] args)
    {

        int height = 4;
        int width = 5;
        int col = 0;
        int row = 0;

        int i = 1;

        Matrix schnecke = new Matrix(height, width);

        /*
        Zustaende:  1- nach rechts
                    2- nach unten
                    3- nach links
                    4- nach oben
         */

        int zustand = 1;
        int versuchsWeg = 0;

        while (versuchsWeg < 2)
        {
            if(schnecke.get(row, col) != 0)
                break;
            schnecke.set(row, col, i);
            i++;

            switch(zustand){
                case 1: {
                    if(col+1 >= width || schnecke.get(row, col+1 ) != 0){
                        versuchsWeg++;
                        zustand++;
                    }
                    else{
                        versuchsWeg = 0;
                        break;
                    }
                }

                case 2: {
                    if(row+1 >= height || schnecke.get(row+1, col ) != 0){
                        versuchsWeg++;
                        zustand++;
                    }
                    else{
                        versuchsWeg = 0;
                        break;
                    }
                }

                case 3: {
                    if(col-1 < 0 || schnecke.get(row, col-1 ) != 0){
                        versuchsWeg++;
                        zustand++;
                    }
                    else{
                        versuchsWeg = 0;
                        break;
                    }
                }
                case 4: {
                    if(row-1 < 0 || schnecke.get(row-1, col ) != 0){
                        versuchsWeg++;
                        zustand = 1;
                    }
                    else{
                        versuchsWeg = 0;
                        break;
                    }
                }


            }
            switch(zustand){
                case 1: col++;
                    break;
                case 2: row++;
                    break;
                case 3: col--;
                    break;
                case 4: row--;
                    break;
            }
        }

        System.out.println(schnecke.toString());
    }
}

