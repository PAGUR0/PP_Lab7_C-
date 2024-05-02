public class GenericArray<T>
{
    private List<T> array;
    private int size;

    public GenericArray(int capacity)
    {
        array = new List<T>();
    }

    public void AddElement(T element)
    {
        array.Add(element);
    }

    public void RemoveElement(int index)
    {
        array.RemoveAt(index);
    }

    public T GetElement(int index)
    {
        return array[index];
    }

    public int GetLength()
    {
        return array.Count;
    }
}

class Program
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.AddElement(1);
        intArray.AddElement(2);
        intArray.AddElement(3);

        GenericArray<string> stringArray = new GenericArray<string>(3);
        stringArray.AddElement("hello");
        stringArray.AddElement("world");

        GenericArray<double> doubleArray = new GenericArray<double>(4);
        doubleArray.AddElement(3.14);
        doubleArray.AddElement(2.71);

        Console.WriteLine("Длина массива целых чисел: " + intArray.GetLength());
        Console.WriteLine("Элемент по индексу 1 из строкового массива: " + stringArray.GetElement(1));
        Console.WriteLine("Элемент по индексу 0 из массива чисел с плавающей точкой: " + doubleArray.GetElement(0));
    }
}