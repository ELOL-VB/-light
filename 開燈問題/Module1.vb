Module Module1

    Sub Main()
        Dim n, k, z As Integer
        Dim str As String
        str = ""
        Console.Write("請輸入幾盞燈")
        n = Console.ReadLine
        Dim a(n) As Integer
        Console.Write("請輸入幾人")
        k = Console.ReadLine()
        For z = 1 To n
            a(z) = 1
            'Console.WriteLine(a(z))

            For j = 2 To k
                If z Mod j = 0 Then
                    If a(z) = 1 Then
                        a(z) = 0
                    Else
                        a(z) = 1
                    End If
                End If
            Next
        Next
        For z = 1 To n
            If a(z) = 1 Then
                str = str & z & " "
            End If
        Next

        Console.Write(str)
        Console.Read()
    End Sub

End Module
