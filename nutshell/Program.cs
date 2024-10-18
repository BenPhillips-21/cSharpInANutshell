UnitConverter feetToInchesConverter = new UnitConverter (12);
UnitConverter milesToFeetConverter  = new UnitConverter (5280);

Console.WriteLine (feetToInchesConverter.Convert(30));    // 360

Console.WriteLine (feetToInchesConverter.Convert(
    milesToFeetConverter.Convert(1)));     // 63360

public class UnitConverter
{
    int ratio;                              // Field

    public UnitConverter (int unitRatio)    // Constructor
    {
        ratio = unitRatio;
    } 

    public int Convert (int unit)           // Method
    {
        return unit * ratio;
    } 
}