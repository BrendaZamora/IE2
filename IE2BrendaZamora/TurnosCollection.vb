Imports System.ComponentModel

Public Class TurnosCollection
    Inherits BindingList(Of Turnos)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        e.NewObject = New Turnos()

    End Sub
End Class
