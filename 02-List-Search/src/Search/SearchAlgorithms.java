package SearchAlgorithms;

public class SearchAlgorithms
{

   public static int naiveSearchWithout(String[] data, String keyword)
	{
		for (int i = 0; i < data.length; i++)
		{
			if (data[i].equals(keyword))
			{
				return i;
			}
		}
		return -1;
	}
   
   public static WithCount<Integer> naiveSearch(String[] data, String keyword)
	{
		int counter = 0;
		for (int i = 0; i < data.length; i++)
		{
			counter++;
			if (data[i].equals(keyword))
			{
				return new WithCount<>(i, counter);
			}
		}
		return new WithCount<>(-1, counter);
	}

   public static int binarySearchWithout(String[] data, String keyword)
	{
		int left = 0;
		int right = data.length - 1;
		while (left <= right)
		{
			int center = (right + left) / 2;
			if (data[center].equals(keyword))
			{
				return center;
			}
		if (keyword.compareTo(data[center])<0)
		{
			right = center - 1;
		}
		else
		{
			left = center + 1;
		}
		}
		return -1;
	}
	
	public static WithCount<Integer> binarySearch(String[] data, String keyword)
	{
	int counter = 0;
	int left = 0;
	int right = data.length - 1;
	while (left <= right)
	{
		int center = (right + left) / 2;
		counter++;
		if (data[center].equals(keyword))
		{
			return new WithCount<>(center, counter);
		}
		counter++;
		if (keyword.compareTo(data[center])<0)
		{
			right = center - 1;
		}
		else
		{
			left = center + 1;
		}
	}
	return new WithCount<>(-1, counter);
	}
}
