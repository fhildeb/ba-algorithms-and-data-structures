package Lists;

import java.util.Iterator;

public class ListNode<T> implements IListNode<T>
{
	private T element;
	private ListNode<T> next;
	private ListNode<T> prev;
	
	public ListNode(T elem)
	{
		this(elem, null, null);
	}
	
	public ListNode(T elem, ListNode<T> n, ListNode<T> p)
	{
		this.element = elem;
		this.next = n;
		this.prev = p;
	}
	
	public T getElement() 
	{
		return this.element;
	}
	
	public ListNode<T> getPrev() 
	{ 
		return this.prev;
	}
	
	public ListNode<T> getNext() 
	{
		return this.next; 
	}
	
	public void setElement(T element) 
	{
		this.element = element;
	}
	
	public void setPrev(ListNode<T> prev) 
	{
		this.prev = prev;
	}
	
	public void setNext(ListNode<T> next) 
	{ 
		this.next = next;
	}

	@Override
	public void addFirst(T element) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void addLast(T element) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public T removeFirst() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public T removeLast() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public long getSize() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public Iterator<T> iterator() {
		// TODO Auto-generated method stub
		return null;
	}
}
