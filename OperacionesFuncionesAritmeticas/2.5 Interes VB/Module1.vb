Module Module1

    Sub Main()

        Dim monto, interes_anual, Interes, tiempo, capAcumulado As Decimal

        Console.WriteLine("Ingresar un monto: ")
        monto = Console.ReadLine()

        Console.WriteLine("Ingresar interes: ")
        interes_anual = Console.ReadLine()

        Console.WriteLine("Ingresar cantidad de dias: ")
        tiempo = Console.ReadLine()

        Interes = (monto * interes_anual * tiempo) / (360 * 100)

        capAcumulado = Interes + monto

        Console.WriteLine("El total es de: " & Interes)
        Console.WriteLine("El capital acumulado es de: " & capAcumulado)

    End Sub

End Module
