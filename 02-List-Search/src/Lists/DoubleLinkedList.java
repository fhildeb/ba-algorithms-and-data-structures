package Lists;

import java.util.Iterator;

public class DoubleLinkedList<T> implements IListNode<T>
{

   private ListNode<T> head;
   private ListNode<T> tail;
   private int size;

   public DoubleLinkedList()
   {
      head = null;
	  tail = null;
	  size = 0;
   }

   @Override
   public void addFirst(T element)
	{
		ListNode<T> node = new ListNode<>(element);
		node.setNext(head);
		if (head == null)
		{
			tail = node;
		}
		else
		{
			head.setPrev(node);
		}
		head = node;
		size++;
	}

   @Override
   public void addLast(T element)
   {
	  ListNode<T> node = new ListNode<>(element);
		node.setPrev(tail);
		if (tail == null)
		{
			head = node;
		}
		else
		{
			tail.setNext(node);
		}
		tail = node;
		size++;
   }

    @Override
    public T removeFirst()
	{
		if (head == null)
		{
			throw new RuntimeException("List Empty.");
		}
		
		ListNode<T> result = head;
		head = head.getNext();
		if (head == null)
		{
			tail = null;
		}
		else
		{
			head.setPrev(null);
		}
		size--;
		return result.getElement();
	}

   @Override
   public T removeLast()
   {
      if (tail == null)
		{
			throw new RuntimeException("List Empty.");
		}
		
		ListNode<T> result = tail;
		tail = tail.getPrev();
		if (tail == null)
		{
			head = null;
		}
		else
		{
			tail.setNext(null);
		}
		size--;
		return result.getElement();
   }

   @Override
   public long getSize()
   {
      return size;
   }

   @Override
   public Iterator<T> iterator()
   {
    //  return new ListNodeIterator<>(head);
	   return null;
   }

}

