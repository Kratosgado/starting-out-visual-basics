' Addition program

Module modAddition
    Sub main()

        ' variables used in addition calculation
        Dim number1, number2, sumOfNumbers As Integer

        ' read first number from user
        Console.Write("Please enter the first integer: ")
        number1 = Console.ReadLine()

        ' read second number from user
        Console.Write("Please enter the second integer: ")
        number2 = Console.ReadLine()

        ' convert input values to integers


        sumOfNumbers = number1 + number2 ' add numbers

        ' display results
        Console.WriteLine("The sum is {0}", sumOfNumbers)
    End Sub ' main
End Module ' modAddition