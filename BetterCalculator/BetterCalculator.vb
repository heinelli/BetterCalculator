﻿Option Strict On
Option Explicit On
Module BetterCalculator
    Sub Main()
        Dim num1 As Double
        Dim input1 As Boolean = False
        Dim num2 As Double
        Dim input2 As Boolean = False
        Dim decision As Boolean = False
        Dim operator1 As Integer

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
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")

        Do While decision = False
            Try
                operator1 = CInt(Console.ReadLine())
                If operator1 = 1 Then
                    Console.WriteLine(num1 + num2)
                ElseIf operator1 = 2 Then
                    Console.WriteLine(num1 - num2)
                ElseIf operator1 = 3 Then
                    Console.WriteLine(num1 * num2)
                ElseIf operator1 = 4 Then
                    Console.WriteLine(num1 / num2)
                End If
                decision = True
            Catch
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                decision = False

            End Try

        Loop
        Console.WriteLine("Good job!")
        Console.Read()

    End Sub

End Module
