Module Redondeo

    Sub Main()

        Dim numero As Double

        Console.Write("Ingrese un numero Real: ")

        numero = Console.ReadLine()

        Console.WriteLine("Por exceso: " & Math.Ceiling(numero))
        Console.WriteLine("Por defecto: " & Math.Floor(numero))
        Console.WriteLine("Por redondeo: " & Math.Round(numero))

    End Sub

End Module
