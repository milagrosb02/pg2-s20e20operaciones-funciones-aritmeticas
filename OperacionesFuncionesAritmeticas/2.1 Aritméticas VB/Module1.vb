Module Aritmeticas

    Sub Main()

        Dim numero As UShort

        Console.WriteLine("Ingresar un numero: ")
        numero = Console.ReadLine()

        Console.WriteLine("Resto del numero: " & numero Mod 2)
        Console.WriteLine("Valor absoluto: " & Math.Abs(numero))
        Console.WriteLine("Elevado a la decima potencia: " & Math.Pow(numero, 10))
        Console.WriteLine("Raiz cuadrada: " & Math.Sqrt(numero))

    End Sub

End Module
