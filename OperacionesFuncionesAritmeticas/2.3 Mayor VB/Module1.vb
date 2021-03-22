Module Mayor

    Sub Main()

        Dim valor1, valor2, valor3 As Double

        Console.WriteLine("Ingresar primer valor: ")
        valor1 = Console.ReadLine()

        Console.WriteLine("Ingresar segundo valor: ")
        valor2 = Console.ReadLine()

        Console.WriteLine("Ingresar tercer valor: ")
        valor3 = Console.ReadLine()

        Console.WriteLine("El mayor numero es: " & Math.Max(valor1, Math.Max(valor2, valor3)))


    End Sub

End Module
