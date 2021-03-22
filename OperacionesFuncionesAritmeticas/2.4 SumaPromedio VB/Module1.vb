Module SumaPromedio

    Sub Main()

        Dim num1, num2, num3, num4, suma As UShort

        Dim media As Double

        Console.WriteLine("Ingrese primer numero: ")
        num1 = Console.ReadLine()

        Console.WriteLine("Ingrese segundo numero: ")
        num2 = Console.ReadLine()

        Console.WriteLine("Ingrese tercer numero: ")
        num3 = Console.ReadLine()

        Console.WriteLine("Ingrese cuarto numero: ")
        num4 = Console.ReadLine()

        suma = num1 + num2 + num3 + num4
        media = suma / 4

        Console.WriteLine("La sumatoria de los numeros ingresados es: " & suma)
        Console.WriteLine("La media de los numeros ingresados es: " & media)

    End Sub

End Module
