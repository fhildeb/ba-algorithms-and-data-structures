package Arrays;

public class ArrayUtils {

    public static void main(String[] args) {
        int[] a = new int[]{1, 2, 3, 4, 5, 6, 7, 8};

        System.out.println(toString(a));

        int[] b = reverse(a);
        System.out.println(toString(b));

        int[] c = append(b, 9);
        System.out.println(toString(c));

        int[] d = insertAt(c, 17, 4);
        System.out.println(toString(d));
        
        d = insertAt(d, 23, 9);
        System.out.println(toString(d));
        
        d = insertAt(d, 27, 11);
        System.out.println(toString(d));
        
        System.out.println("End of regular Expression");
    }

    public static String toString(int[] arr) {
        return toString(arr, '[', ']');
    }

    public static String toString(int[] arr, char pre, char post) {
        StringBuilder s = new StringBuilder();
        s.append(pre);
        for (int i = 0; i < arr.length; i++) {
            if (i > 0) {
                s.append(", ");
            }
            s.append(String.format("%8d", arr[i]));
        }
        s.append(post);
        return s.toString();
    }

    public static int[] reverse(int[] arr) {
        int[] arrResult = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            arrResult[i] = arr[arr.length - i - 1];
        }

        return arrResult;
    }

    public static int[] append(int[] arr, int e) {
        int[] arrResult = new int[arr.length + 1];
        System.arraycopy(arr, 0, arrResult, 0, arr.length);
        arrResult[arr.length] = e;
        return arrResult;
    }

    public static int[] insertAt(int[] arr, int e, int index) {
        int[] arrResult = new int[arr.length + 1];
        System.arraycopy(arr, 0, arrResult, 0, index);
        arrResult[index] = e;
        System.arraycopy(arr, index, arrResult, index + 1, arr.length - index);
        return arrResult;
    }
}

