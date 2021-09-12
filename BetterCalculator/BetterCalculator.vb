'Elliot Heiner
'RCET0265
'Fall 2021
'Better Calculator
'https://github.com/heinelli/BetterCalculator.git

Option Strict On
Option Explicit On
Option Compare Text
Module BetterCalculator
    Sub Main()
        Dim num1 As Double
        Dim input1 As Boolean = False
        Dim num2 As Double
        Dim input2 As Boolean = False
        Dim decision As Boolean = False
        Dim operator1 As Double
        Dim userInput As String
        Dim exit1 As Boolean = False


        Do Until exit1 = True
            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")
            Console.WriteLine("Choose a number")

            Do While input1 = False
                Try
                    userInput = Console.ReadLine()
                    num1 = CDbl(userInput)                      'Causes exception if any input other than a number is typed.
                    Console.WriteLine("You entered " & num1)
                    input1 = True
                Catch
                    If userInput = "Q" Then
                        input1 = True
                        exit1 = True
                    Else
                        Console.WriteLine("You entered " & userInput)
                        Console.WriteLine("Please enter a whole number.")
                        input1 = False
                    End If
                End Try
            Loop

            If exit1 <> True Then
                Console.WriteLine("Choose a number.")
                Do While input2 = False
                    Try
                        userInput = Console.ReadLine()
                        num2 = CDbl(userInput)
                        Console.WriteLine("You entered " & num2)
                        input2 = True
                    Catch
                        If userInput = "Q" Then
                            input2 = True
                            exit1 = True
                        Else
                            Console.WriteLine("You entered " & userInput)
                            Console.WriteLine("Please enter a whole number.")
                            input2 = False
                        End If
                    End Try
                Loop
                If exit1 <> True Then
                    Console.WriteLine("Choose one of the following options:")
                    Console.WriteLine("1. Add")
                    Console.WriteLine("2. Subtract")
                    Console.WriteLine("3. Multiply")
                    Console.WriteLine("4. Divide")

                    Do While decision = False
                        Try
                            userInput = (Console.ReadLine())
                            operator1 = CDbl(userInput)
                            If operator1 = 1 Then
                                Console.WriteLine("You entered 1")
                                Console.WriteLine(num1 & "+" & num2 & "=" & num1 + num2)
                                decision = True
                            ElseIf operator1 = 2 Then
                                Console.WriteLine("You entered 2")
                                Console.WriteLine(num1 & "-" & num2 & "=" & num1 - num2)
                                decision = True
                            ElseIf operator1 = 3 Then
                                Console.WriteLine("You entered 3")
                                Console.WriteLine(num1 & "*" & num2 & "=" & num1 * num2)
                                decision = True
                            ElseIf operator1 = 4 Then
                                Console.WriteLine("You entered 4")
                                Console.WriteLine(num1 & "/" & num2 & "=" & num1 / num2)
                                decision = True
                            Else
                                decision = False
                                Console.WriteLine("Choose one of the following options:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                            End If
                        Catch
                            If userInput = "Q" Then
                                decision = True
                                exit1 = True
                            Else
                                Console.WriteLine("Choose one of the following options:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                                decision = False
                            End If
                        End Try
                    Loop
                    input1 = False
                    input2 = False      'Prevents code from running infinitely after one calculation.
                    decision = False
                End If
            End If
        Loop
        Console.WriteLine("You entered Q")
        Console.WriteLine("Have a nice day.")
        Console.WriteLine("Press ENTER to close this window.")
        Console.ReadLine()
    End Sub

End Module
