Imports System


Imports System.Linq.Expressions
Imports System.Runtime.Intrinsics.Arm
Public Sub Main(args As String(), console As Console)
    If console Is Nothing Then
        Throw New ArgumentNullException(NameOf(console))
    End If

    Dim p, i As String
    Console.WriteLine(" Óìåþ ñ÷èòàòü ïðîèçâåäåíèå")
    Console.WriteLine("Íàïèøè 1 åñëè òû çàêîí÷èë ")
    i = 0
    p = 1
    While (i <> 1)
        If i = CInt(Console.ReadLine()) Then
            p = p * i
            If (i = 1) Then
            End If
        End If
    End While
    If p > (Int64.MaxValue / p) Then
        Console.Write(" Ïàìÿòü ïåðåãðóæèíà !!! = ")
        Console.Write(p)

    End If

End Sub