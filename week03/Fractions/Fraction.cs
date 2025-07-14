public class Fraction
{
    private int _top;
    private int _bottom;
    // Constructor 1: no parameters (defaults to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // Constructor 2: one parameter (numerator only, denominator = 1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    // Constructor 3: two parameters (numerator and denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}