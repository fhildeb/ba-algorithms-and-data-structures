package Lists;

import java.util.Iterator;

public interface IListNode<T> {

	void addFirst(T element);

	void addLast(T element);

	T removeFirst();

	T removeLast();

	long getSize();

	Iterator<T> iterator();
	
}
