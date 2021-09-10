Option Strict On
Option Explicit On
Module BetterCalculator
    Sub Main()
        Dim num1 As Double

        Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")
        Console.WriteLine("Choose a number")
        Try
            num1 = Double.Parse(Console.ReadLine())
            Console.WriteLine(num1)
            Console.Read()
        Catch
            Console.Write("Please enter a whole number.")
            Console.Read()
        End Try


    End Sub

End Module
