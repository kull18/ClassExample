var number1 = new MyList<int>(5); 
var nnumbers = new MyList<String>(20);

//new number for my class
var newNumbers = new MyList<String>(20);

number1.Add(2);
number1.Add(2);
number1.Add(5); 
number1.Add(5);
number1.Add(20);

Console.WriteLine(number1.getCount()); 
public class MyList<T>
{
    private List<T> _list;
    private int _limit; 

    public MyList(int limit)
    {
        _limit = limit; 
        _list = new List<T>(); 
    }

    public void Add(T Element) 
    {
        if(_list.Count < _limit)
        {
            _list.Add(Element);
        }
    }

    public string getCount()
    {
        String content = "";
        foreach (T Element in _list)
        {
            content += Element + ","; 
        }

        return content; 
    }

}