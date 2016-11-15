<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.proxyData = New System.Windows.Forms.ListView()
        Me.ip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.port = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.anonymity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.google = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.https = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lastchecked = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(321, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Download Proxies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'proxyData
        '
        Me.proxyData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ip, Me.port, Me.code, Me.country, Me.anonymity, Me.google, Me.https, Me.lastchecked})
        Me.proxyData.FullRowSelect = True
        Me.proxyData.GridLines = True
        Me.proxyData.Location = New System.Drawing.Point(12, 40)
        Me.proxyData.Name = "proxyData"
        Me.proxyData.Size = New System.Drawing.Size(649, 358)
        Me.proxyData.TabIndex = 1
        Me.proxyData.UseCompatibleStateImageBehavior = False
        Me.proxyData.View = System.Windows.Forms.View.Details
        '
        'ip
        '
        Me.ip.Text = "IP"
        Me.ip.Width = 120
        '
        'port
        '
        Me.port.Text = "Port"
        '
        'code
        '
        Me.code.Text = "Code"
        '
        'country
        '
        Me.country.Text = "Country"
        Me.country.Width = 90
        '
        'anonymity
        '
        Me.anonymity.Text = "Anonymity"
        '
        'google
        '
        Me.google.Text = "Google"
        '
        'https
        '
        Me.https.Text = "HTTPS"
        '
        'lastchecked
        '
        Me.lastchecked.Text = "Last Checked"
        Me.lastchecked.Width = 130
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(340, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(321, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Export (IP:Port)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(649, 32)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(673, 435)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.proxyData)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arcaneyon's AutoProxy Locator v3 .NET"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ip As System.Windows.Forms.ColumnHeader
    Friend WithEvents port As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents country As System.Windows.Forms.ColumnHeader
    Friend WithEvents anonymity As System.Windows.Forms.ColumnHeader
    Friend WithEvents google As System.Windows.Forms.ColumnHeader
    Friend WithEvents https As System.Windows.Forms.ColumnHeader
    Friend WithEvents lastchecked As System.Windows.Forms.ColumnHeader
    Friend WithEvents proxyData As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
