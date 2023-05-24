<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVistaPrevia
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsBDPrueba26 = New RegistroPersonas.DsBDPrueba26()
        Me.DsBDPrueba26BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DsBDPrueba26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBDPrueba26BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DsBDPrueba26BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RegistroPersonas.RptPersonas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 554)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsBDPrueba26
        '
        Me.DsBDPrueba26.DataSetName = "DsBDPrueba26"
        Me.DsBDPrueba26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsBDPrueba26BindingSource
        '
        Me.DsBDPrueba26BindingSource.DataSource = Me.DsBDPrueba26
        Me.DsBDPrueba26BindingSource.Position = 0
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "FrmVistaPrevia"
        CType(Me.DsBDPrueba26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBDPrueba26BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DsBDPrueba26BindingSource As BindingSource
    Friend WithEvents DsBDPrueba26 As DsBDPrueba26
End Class
