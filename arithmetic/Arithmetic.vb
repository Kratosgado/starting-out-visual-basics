' Arithmetic
' VB program to perform arithmetic operations

Module modArithmetic
    Sub main(args As String())
        ' declare the variables for the integers
        Dim first, second As Integer

        'get the numbers from the user
        Console.Write("Enter the first number: ")
        first = Console.ReadLine()
        Console.Write("Enter the second number: ")
        second = Console.ReadLine()

        Console.WriteLine("Addition = {0}", (first + second)) ' addition
        Console.WriteLine("Subtraction = {0}", (first - second)) ' subtraction
        Console.WriteLine("Float division between {0} and {1} = {2}", first, second, (first / second)) ' float division
        Console.WriteLine("Interger division = {0}", (first \ second)) ' integer division
        Console.WriteLine("Multiplication = {0}", (first * second)) 'multiplication
        Console.WriteLine("Modulo = {0}", (first Mod second)) ' modulo
    End Sub ' main
End Module ' modArithmetic