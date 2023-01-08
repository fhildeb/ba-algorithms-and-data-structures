package Matrix;

import java.util.ArrayList;

import Arrays.ArrayUtils;

public class Matrix {

    private int height;
    private int width;
    private int[][] m;

    public static void main(String[] args) {
        Matrix m = new Matrix(3, 4);
        m.setValuesLineByLine(2, 4, 6, 8, 1, 2, 3, 4, 1, 2, 4, 8);
        System.out.println(m.toString());

        System.out.println(ArrayUtils.toString(m.getColSums()));
        System.out.println(ArrayUtils.toString(m.getRowSums()));

        Matrix t = m.transpose();
        System.out.println("transposed: \n" + t.toString());

        System.out.println(ArrayUtils.toString(t.getColSums()));
        System.out.println(ArrayUtils.toString(t.getRowSums()));

        System.out.println(schnecke(5, 11).toString());


        Matrix q = new Matrix(4, 4);
        q.setValuesLineByLine(16, 3, 2, 13, 5, 10, 11, 8, 9, 6, 7, 12, 4, 15, 14, 1);
        System.out.println(magischesQuadrat(q, false));
    }

    /**
     * Legt eine neue Matrix an.
     *
     * @param height H&ouml;he
     * @param width  Breite
     */
    public Matrix(int height, int width) {
        m = new int[height][width];
        this.height = height;
        this.width = width;
    }

    /**
     * Gibt einen Wert zur&uuml;
     *
     * @param row Reihenindex
     * @param col Spaltenindex
     * @return Wert
     */
    public int get(int row, int col) {
        return m[row][col];
    }

    /**
     * Setzt den Wert einer Zelle
     *
     * @param row Reihenindex
     * @param col Spaltenindex
     * @param val Wert
     */
    public void set(int row, int col, int val) {
        m[row][col] = val;
    }

    /**
     * Gibt die H&ouml;he der Matrix zur&uuml;ck
     * @return H&ouml;he
     */
    public int getHeight() {
        return height;
    }

    /**
     * Gibt die Breite der Matrix zur&uuml;ck
     * @return Breite
     */
    public int getWidth() {
        return width;
    }

    /**
     * F&uuml;gt Werte in die Matrix ein
     * @param values neue Werte
     * @throws ArrayIndexOutOfBoundsException   wenn mehr Werte gegeben werden, als Zellen vorhanden sind
     */
    public void setValuesLineByLine(int... values) throws ArrayIndexOutOfBoundsException {
        int row = 0, col = 0;

        for (int val : values) {
            if (row >= m.length) {
                throw new ArrayIndexOutOfBoundsException("Zu viele Werte");
            }
            m[row][col] = val;
            col++;
            if (col >= m[0].length) {
                row++;
                col = 0;
            }
        }
    }

    /**
     * Gibt die Matrix als String aus
     * @return Matrix
     */
    public String toString() {
        StringBuilder s = new StringBuilder();
        for (int row = 0; row < height; row++) {
            char start;
            char end;

            if (row == 0) {
                start = '\u250C';
                end = '\u2510';
            } else if (row == height - 1) {
                start = '\u2514';
                end = '\u2518';
            } else {
                start = '\u2502';
                end = '\u2502';
            }
            s.append(ArrayUtils.toString(m[row], start, end));
            s.append("\n");
        }
        return s.toString();
    }

    /**
     * Gibt die Summe der einzelnen Reihen als Array zur&uuml;ck
     * @return Reihensummen
     */
    public int[] getRowSums() {
        int[] sums = new int[height];

        for (int row = 0; row < height; row++) {
            sums[row] = 0;
            for (int col = 0; col < width; col++) {
                sums[row] += m[row][col];
            }
        }
        return sums;
    }

    /**
     * Gibt die Summe der einzelnen Spalten als Array zur&uuml;ck
     * @return Spaltensummen
     */
    public int[] getColSums() {
        int[] sums = new int[width];

        for (int col = 0; col < width; col++) {
            sums[col] = 0;
            for (int row = 0; row < height; row++) {
                sums[col] += m[row][col];
            }
        }
        return sums;
    }

    /**
     * Gibt die Summe der beiden Diagonalen als Array zur&uuml;ck
     * @return Diagonalsummen
     * @throws KeinQuadratException Matrix ist kein Quadrat
     */
    public int[] getDiagSums() throws KeinQuadratException {
        if (width != height) {
            throw new KeinQuadratException("Matrix ist kein Quadrat");
        }

        int[] sums = new int[2];

        for (int i = 0; i < width; i++) {
            sums[0] += m[i][i];
            sums[1] += m[width - i - 1][i];
        }
        return sums;

    }

    /**
     * Transponiert die Matrix
     * @return transponierte Matrix
     */
    public Matrix transpose() {
        Matrix neu = new Matrix(width, height);
        for (int row = 0; row < height; row++) {
            for (int col = 0; col < width; col++) {
                neu.set(col, row, m[row][col]);
            }
        }
        return neu;
    }

    /**
     * Erstellt eine neue Schnecken-Matrix
     * @param h H&ouml;he
     * @param w Breite
     * @return  Schnecken-Matrix
     */
    public static Matrix schnecke(int h, int w) {
        Matrix schnecke = new Matrix(h, w);
        int x = 0, y = 0;
        int left = 0, right = w - 1, top = 0, bottom = h - 1;
        /*
        1   ->
        2   \/
        3   <-
        4   /\
         */
        int direction = 1;
        for (int i = 0; i < w * h; i++) {
            schnecke.set(y, x, i + 1);
            switch (direction) {
                case 1:
                    x++;
                    if (x == right) {
                        direction = 2;
                        top++;
                    }
                    break;
                case 2:
                    y++;
                    if (y == bottom) {
                        direction = 3;
                        right--;
                    }
                    break;
                case 3:
                    x--;
                    if (x == left) {
                        direction = 4;
                        bottom--;
                    }
                    break;
                case 4:
                    y--;
                    if (y == top) {
                        direction = 1;
                        left++;
                    }
                    break;
            }
        }
        return schnecke;
    }

    /**
     * Pr&uuml;ft, ob eine Matrix ein "magisches Quadrat" darstellt
     * @param matrix    zu pr&uuml;fende Matrix
     * @param semimagisch   z&auml;hlen auch "semimagische Quadrate"?
     * @return  (semi)magisches Quadrat?
     */
    public static boolean magischesQuadrat(Matrix matrix, boolean semimagisch) {
        // kein Quadrat
        if (matrix.getHeight() != matrix.getWidth()) {
            return false;
        }

        int laenge = matrix.getWidth();

        // nicht alle oder falsche Zahlen vorhanden
        ArrayList<Integer> fehlend = new ArrayList<>((int) Math.pow(laenge, 2));
        for (int i = 0; i < fehlend.size(); i++) {
            fehlend.add(i);
        }
        for (int i = 0; i < fehlend.size(); i++) {
            int t = matrix.get(i / laenge, i % laenge);
            if (fehlend.contains(t)) {
                fehlend.remove(t);
            } else {
                // falsche Zahl
                return false;
            }
        }
        if (fehlend.size() > 0) {
            // Zahl fehlt
            return false;
        }

        // Zeilensummen oder Spaltensummen nicht identisch
        int[] zeilensummen = matrix.getRowSums();
        int[] spaltensummen = matrix.getColSums();
        int summe = zeilensummen[0];
        for (int s : zeilensummen) {
            if (s != summe) {
                return false;
            }
        }
        for (int s : spaltensummen) {
            if (s != summe) {
                return false;
            }
        }

        if (semimagisch) {
            return true;
        }

        try {
            int[] diagsummen = matrix.getDiagSums();
            for (int s : diagsummen) {
                if (s != summe) {
                    return false;
                }
            }
        } catch (KeinQuadratException e) {
            e.printStackTrace();
        }
        return true;
    }

}


class KeinQuadratException extends Exception {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	KeinQuadratException() {
        super("Kein Quadrat");
    }

    KeinQuadratException(String msg) {
        super(msg);
    }
}