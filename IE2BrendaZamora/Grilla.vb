Public Class Grilla

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub


    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
       Form1.operacion = "Agregar"
        Form1.Text = "Agrega"
        Form1.Show()
    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If lst.Count = 0 Then Exit Sub

        Form1.operacion = "Eliminar"
        Form1.Text = "Elimina"
        Form1.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form1.Show()
    End Sub


    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Form1.operacion = "Modificar"
        Form1.Text = "Modifica"
        Form1.Show()
    End Sub

    Private Sub llenarform()
        Form1.Id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form1.Fecha.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form1.Asignatura.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Form1.Docente.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form1.Vocal1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        Form1.Vocal2.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
    End Sub


    Private Sub Grilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst

    End Sub
End Class