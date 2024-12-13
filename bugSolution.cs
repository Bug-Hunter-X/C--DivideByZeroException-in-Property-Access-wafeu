public class ExampleClass{
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        try {
            int result = MyProperty / 0; //Potential DivideByZeroException
        } catch (DivideByZeroException ex) {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}