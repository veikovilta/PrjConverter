Public Class CConverter
    Implements Iconverter

    Const KM2MI = 1.609344

    Public Function ConvertKilometersToMiles(kilometers As Double) As Double Implements Iconverter.ConvertKilometersToMiles
        Return kilometers / KM2MI
    End Function
End Class
