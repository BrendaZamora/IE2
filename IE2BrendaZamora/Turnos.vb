Public Class Turnos
    Dim Id_ As Integer
    Dim Fecha_ As Date
    Dim Asignatura_, Docente_, Vocal1_, Vocal2_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value

        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value

        End Set
    End Property

    Public Property Asignatura() As String
        Get
            Return Asignatura_
        End Get
        Set(ByVal value As String)
            Asignatura_ = value

        End Set
    End Property

    Public Property Docente() As String
        Get
            Return Docente_
        End Get
        Set(ByVal value As String)
            Docente_ = value

        End Set
    End Property

    Public Property Vocal1() As String
        Get
            Return Vocal1_
        End Get
        Set(ByVal value As String)
            Vocal1_ = value

        End Set
    End Property

    Public Property Vocal2() As String
        Get
            Return Vocal2_
        End Get
        Set(ByVal value As String)
            Vocal2_ = value

        End Set
    End Property
End Class
