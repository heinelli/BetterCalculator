Option Strict On
Option Explicit On
Module BetterCalculator
    Sub Main()
        Dim num1 As Double
        Dim input1 As Boolean = False
        Dim num2 As Double
        Dim input2 As Boolean = False

        Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")
        Console.WriteLine("Choose a number")
        Do While input1 = False
            Try
                num1 = Double.Parse(Console.ReadLine())
                Console.WriteLine("You entered " & num1)
                input1 = True
            Catch
                Console.WriteLine("Please enter a whole number.")
                input1 = False
            End Try
        Loop
        Console.WriteLine("Choose a second number.")
        Do While input2 = False
            Try
                num2 = Double.Parse(Console.ReadLine())
                Console.WriteLine("You entered " & num2)
                input2 = True
            Catch
                Console.Write("Please enter a whole number.")
                input2 = False
            End Try
        Loop
        Console.Read()

    End Sub

End Module
