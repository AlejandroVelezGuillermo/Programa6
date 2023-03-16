Imports System.IO

Public Class Form1



    Private Sub GuardarButton_Click_1(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Try
            ' Abrir el archivo binario en modo de escritura
            Using archivo As New FileStream("numeros.bin", FileMode.Create, FileAccess.Write)
                ' Convertir la lista de números a bytes
                Dim numeros As Byte() = System.Text.Encoding.UTF8.GetBytes(Lista.Text)
                ' Escribir los bytes en el archivo
                archivo.Write(numeros, 0, numeros.Length)
                ' Mostrar un mensaje de éxito
                ArchivoGuardadoLabel.Text = "Archivo guardado exitosamente."
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje de error
            MessageBox.Show("Error al guardar el archivo: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarButton_Click(sender As Object, e As EventArgs) Handles CargarButton.Click
        Try
            ' Abrir el archivo binario en modo de lectura
            Using archivo As New FileStream("numeros.bin", FileMode.Open, FileAccess.Read)
                ' Leer los bytes del archivo
                Dim numeros As Byte() = New Byte(archivo.Length - 1) {}
                archivo.Read(numeros, 0, numeros.Length)
                ' Convertir los bytes a texto
                Lista.Text = System.Text.Encoding.UTF8.GetString(numeros)
                ' Mostrar un mensaje de éxito
                ArchivoCargadoLabel.Text = "Archivo cargado exitosamente."
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje de error
            MessageBox.Show("Error al cargar el archivo: " & ex.Message)
        End Try
    End Sub
End Class

