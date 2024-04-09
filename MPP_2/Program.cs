using MPP_2.MyFaker;

Faker f = new Faker();
var s = f.Create<TestClass>();
var a = f.Create<TestClass>();

public class TestClass {

    public int a;
    public int b;
    private int t;
    private int y;
    public A cA;

    public int c { get; private set; }
    public int d { private get; set; }
    private int dg {  get; set; }

    public List<int> ListInt;

    public TestClass()
    {
        
    }

    public TestClass(int A, int T)
    {
        a = A;
        t = T;
    }
}

public class A
{
    public int a;
    public int b;

    public A() 
    { 
    
    }
}