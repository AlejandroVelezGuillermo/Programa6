<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GuardarButton = New Button()
        CargarButton = New Button()
        Lista = New TextBox()
        ArchivoCargadoLabel = New Label()
        ArchivoGuardadoLabel = New Label()
        SuspendLayout()
        ' 
        ' GuardarButton
        ' 
        GuardarButton.Location = New Point(63, 314)
        GuardarButton.Name = "GuardarButton"
        GuardarButton.Size = New Size(94, 29)
        GuardarButton.TabIndex = 0
        GuardarButton.Text = "GUARDAD"
        GuardarButton.UseVisualStyleBackColor = True
        ' 
        ' CargarButton
        ' 
        CargarButton.Location = New Point(480, 314)
        CargarButton.Name = "CargarButton"
        CargarButton.Size = New Size(94, 29)
        CargarButton.TabIndex = 1
        CargarButton.Text = "CARGAR"
        CargarButton.UseVisualStyleBackColor = True
        ' 
        ' Lista
        ' 
        Lista.Location = New Point(263, 56)
        Lista.Name = "Lista"
        Lista.Size = New Size(125, 27)
        Lista.TabIndex = 4
        ' 
        ' ArchivoCargadoLabel
        ' 
        ArchivoCargadoLabel.AutoSize = True
        ArchivoCargadoLabel.Location = New Point(507, 248)
        ArchivoCargadoLabel.Name = "ArchivoCargadoLabel"
        ArchivoCargadoLabel.Size = New Size(53, 20)
        ArchivoCargadoLabel.TabIndex = 3
        ArchivoCargadoLabel.Text = "Label1"' 
        ' ArchivoGuardadoLabel
        ' 
        ArchivoGuardadoLabel.AutoSize = True
        ArchivoGuardadoLabel.Location = New Point(74, 221)
        ArchivoGuardadoLabel.Name = "ArchivoGuardadoLabel"
        ArchivoGuardadoLabel.Size = New Size(53, 20)
        ArchivoGuardadoLabel.TabIndex = 2
        ArchivoGuardadoLabel.Text = "Label1"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Lista)
        Controls.Add(ArchivoCargadoLabel)
        Controls.Add(ArchivoGuardadoLabel)
        Controls.Add(CargarButton)
        Controls.Add(GuardarButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GuardarButton As Button
    Friend WithEvents CargarButton As Button
    Friend WithEvents Lista As TextBox
    Friend WithEvents ArchivoCargadoLabel As Label
    Friend WithEvents ArchivoGuardadoLabel As Label
End Class
