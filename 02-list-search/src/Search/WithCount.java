package Search;

public class WithCount<T>
{
	private int count;
	private T data;
	
	public WithCount(T data, int count)
	{
		this.data = data;
		this.count = count;
	}
	
	public int getCount()
	{
		return this.count;
	}
	
	public T getData()
	{
		return this.data;
	}
}
