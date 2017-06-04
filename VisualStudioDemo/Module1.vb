Module Module1

    Sub Main()
        ' Liste von Personen erstellen
        Dim persons As List(Of Person)

        persons = New List(Of Person)

        ' Neue Person hinzufügen
        Dim p As Person

        p = New Person
        p.Name = "Jan"
        p.Age = 20

        persons.Add(p)

        ' Kurzschreibweise
        persons.Add(New Person With {.Name = "Werner", .Age = 56})
        persons.Add(New Person With {.Name = "Egon", .Age = 31})

        ' Liste ausgeben

        For Each item As Person In persons
            Console.WriteLine("{0} ist {1}.", item.Name, item.Age)
        Next

        Console.ReadLine()
    End Sub

End Module

Public Class Person

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Age As Integer
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            _Age = value
        End Set
    End Property

End Class
