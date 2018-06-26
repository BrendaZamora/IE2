Public Class Form1

    Dim operacion_ As String
    Dim MiTurnos As New Turnos
    Dim indice_ As Byte

    Public Property operacion() As String
        Get
            Return operacion_

        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As String
        Get
            Return indice_

        End Get

        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item As String In ComboBox1.Items
            ComboBox2.Items.Add(item)
            ComboBox3.Items.Add(item)

        Next
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If TextBox1.Text = "" Then
            MsgBox("El Id no puede estar vacio")
            Exit Sub

        End If

        If TextBox2.Text = "" Then
            MsgBox("La fecha no puede estar vacia")
            Exit Sub

        End If

        If TextBox3.Text.Trim = "" Then
            MsgBox("La Asignatura no puede estar vacia")
            Exit Sub

        End If

        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una opcion")
            Exit Sub

        End If

        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una opcion")
            Exit Sub

        End If
        If ComboBox3.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una opcion")
            Exit Sub

        End If
        MiTurnos.Id = CInt(TextBox1.Text)
        MiTurnos.Fecha = CDate(TextBox2.Text)
        MiTurnos.Asignatura = TextBox3.Text
        MiTurnos.Docente = ComboBox1.SelectedItem
        MiTurnos.Vocal1 = ComboBox2.SelectedItem
        MiTurnos.Vocal2 = ComboBox3.SelectedItem


        Select Case operacion_
            Case "Agregar"
                lst.Add(MiTurnos)

            Case "Eliminar"
                If lst.Count = 0 Then Exit Sub

                lst.RemoveAt(indice_)

            Case "Modificar"
                If lst.Count = 0 Then Exit Sub

                lst.Item(indice_) = MiTurnos

                Grilla.DataGridView1.Refresh()
        End Select
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not Id.Text.IndexOf(".") Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        Else
            e.Handled = True
        End If
        Exit Sub
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "," And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True

            Exit Sub

        End If
        If Char.IsControl(e.KeyChar) Then

        End If

        Dim pos As Integer = TextBox2.SelectionStart



        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub


        End If


        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub

        End If

        If e.KeyChar = "." Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "," Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            SendKeys.Send("/")
            e.Handled = True
        End If

    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False
        Else

            e.Handled = True
            Exit Sub
        End If
    End Sub


    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True
        End If


    End Sub


    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True
        End If


    End Sub


    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub


   
End Class
