' Using equality and relational operators

Module modComparison
    Sub main()

        ' declare Integer variables for input
        Dim number1, number2 As Integer

        ' read the 2 numbers from the user
        Console.Write("Enter the first number: ")
        number1 = Console.ReadLine()
        Console.Write("Enter the second number: ")
        number2 = Console.ReadLine()

        ' we starting the comparison
        ' if they are equal
        If number1 = number2 Then
            Console.WriteLine("{0} = {1}", number2, number1)
        End If

        ' if not equal to
        If number1 <> number2 Then
            Console.WriteLine("{0} not equal to {1}", number1, number2)
        End If

        ' less than
        If number1 < number2 Then
            Console.WriteLine("{0} < {1}", number1, number2)
        End If

        'greater than or equal to
        If number1 >= number2 Then
            Console.WriteLine("{0} >= {1}", number1, number2)
        End If
    End Sub ' main
End Module ' modComparison