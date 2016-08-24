# UnitConverter-DLL
UnitConverter Dynamic Link Library

Simply declare a variable of the 'UnitConverter' class, then call functions:

public double ConvertTime(string Case, double Time)
public string ConvertDecimalNumber(string Case, int Number)
public double ConvertCurrency(string Case, double Currency)
public double ConvertLiquid(string Case, double Value)
public double ConvertWeight(string Case, double Value)
public double ConvertLength(string Case, double Value)
public double ConvertDegrees(string Case, double Value)
public double ConvertArea(string Case, double Value)
public double ConvertRadiansDegrees(string Case, double Value)

string Case = "FromTo" conversion

Example:
ConvertWeight("PoundsKilograms", ...)
ConvertLength("MilesYards", ...)

Example for whole use:
UnitConverter unitC = new UnitConverter();
double conTime = unitC.ConvertTime("SecondsHours", 100)
