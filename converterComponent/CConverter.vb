Public Class CConverter
    Implements Iconverter

    Const KM2MI = 1.609344
    Private Property DistInMiles As Double

    Public Function ConvertKilometersToMiles(kilometers As Double) As Double Implements Iconverter.ConvertKilometersToMiles
        ConvkmToMi(kilometers)
        Return DistInMiles
    End Function

    Private Sub ConvkmToMi(ByVal km As Double)
        DistInMiles = km / KM2MI
    End Sub
End Class
