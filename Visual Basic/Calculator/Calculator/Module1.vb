Imports System.Console

Module Module1

    Sub Main()
        Dim num_one, num_two, answer As Double
        Dim math_op As String

        ' Tell the user to enter a number
        Write("Enter a number: ")

        ' Assign the variable to the user input
        num_one = ReadLine()

        ' Clear the console after the user enters a number
        Clear()

        ' Tell user to enter a mathematical operator e.g. +, -, / or *
        Write("Enter a mathematical operator: ")

        ' Assign the variable to the user input
        math_op = ReadLine()

        ' Clear the console after the user enters a mathematical operator
        Clear()

        ' Tell the user to enter a number
        Write("Enter another number: ")

        ' Assign the variable to the user input
        num_two = ReadLine()

        ' Clear the console after the user enters a number
        Clear()

        ' Check the value of the operator and perform the relevant calculation
        If math_op = "+" Then
            answer = num_one + num_two
        ElseIf math_op = "/" Then
            answer = num_one / num_two
        ElseIf math_op = "*" Then
            answer = num_one * num_two
        ElseIf math_op = "-" Then
            answer = num_one - num_two
        Else
            Write("Operator not recognised!")
        End If

        ' Write the answer to the cosole
        Write(answer)

        ' Wait for the user to press a key before closing
        ReadKey()

    End Sub

End Module
