'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/JaceFoxman/SayMyName.git

'Options for this project.
Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim name As String

        Console.WriteLine("What is your name?")
        name = Console.ReadLine
        Console.WriteLine()

        Console.Write("Welcome, ")
        Console.Write(name)
        Console.WriteLine()


    End Sub

End Module
