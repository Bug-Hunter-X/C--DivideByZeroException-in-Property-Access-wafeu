public class ExampleClass{
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        // Simulate a potential issue
        int result = MyProperty / 0; //Potential DivideByZeroException
    }
}