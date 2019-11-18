using System;
using System.Text;
public class Program
{
    public static void Main()
    {
        DynamicArray<int> intArray = new DynamicArray<int>();

        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        intArray.Insert(0, 5);
        intArray.Insert(0, 4);
        intArray.Insert(1, 7);
        


        Console.WriteLine(intArray.ToString());
        Console.WriteLine(intArray.Contains(5));
        Console.WriteLine(intArray.IndexOf(5));


    }
}


/* PLAN

    Needed fields

    * Backing array
    * Elements in array count
    * 

 */

public class DynamicArray<T>
{
    private T[] _arr;
    private int _count = 0;
    private int _size = 0;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < _count; i++)
        {
            sb.Append("\n -- " + _arr[i]);
        }

        return sb.ToString();
    }
    public DynamicArray()
    {
        _arr = new T[4];
        _size = 4;
    }

    public DynamicArray(int size)
    {
        if(size < 1) throw new ArgumentOutOfRangeException("The size of the array must be anon negative integer greater than zero");
        _arr = new T[size];
        _size = size;
    }

    public void Insert(int index, T item)
    {
        if(index < 0) throw new ArgumentOutOfRangeException("The index must be non negative integer");
        if(index == _count || index > _count) throw new ArgumentOutOfRangeException("The index does not exist in the array");
        if(ShouldGrowArray()) GrowArray();
        T[] tempArr = new T[_size];

        for(int i = 0; i < _count - 1; i++)
        {
            //create new array that is size of existing array
            //copy elements until new element position, then fix element into position

            if(i == index)
            {
                tempArr[i] = item;
                _count++;
                tempArr[i + 1] = _arr[i];
            }
            else if(i > index)
            {
                tempArr[i + 1] = _arr[i];
            }
            else
            {
                tempArr[i] = _arr[i];
            }

        }

        _arr = tempArr;
    }


    private bool ShouldGrowArray() { return _count == _size; }

    private void GrowArray()
    {
        T[] tempArr = new T[_size * 2];

        for(int i = 0; i < _size; i++)
        {
            tempArr[i] = _arr[i];
        }

        _arr = tempArr;
        _size *= 2;
    }

    public void Add(T item)
    {
        if(ShouldGrowArray()) GrowArray();
        _arr[_count] = item;
        _count++;
     
    }

    public bool Contains(T item)
    {
       return IndexOf(item) != -1;
    }

    public int IndexOf(T item)
    {
        for(int i = 0; i < _count; i++)
        {
            if(_arr[i] == item)
                return i;
        }
        return -1;
    }

    public void Remove(T item)
    {
        for(int i = 0; i < _count; i++)
        {
            if(_arr[i] == item)
            {

            }
        }
    }
}