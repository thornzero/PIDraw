<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uxMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uxMainForm))
        Me.uxCanvas = New System.Windows.Forms.PictureBox()
        Me.uxStatusBar = New System.Windows.Forms.StatusStrip()
        Me.uxCursorPositionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.uxMenuBar = New System.Windows.Forms.MenuStrip()
        Me.uxMenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uxMenuFileExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileExportPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileExportJpg = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFileExportPng = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxCycleTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.uxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uxStatusBar.SuspendLayout()
        Me.uxMenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'uxCanvas
        '
        Me.uxCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.uxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxCanvas.Location = New System.Drawing.Point(0, 0)
        Me.uxCanvas.Name = "uxCanvas"
        Me.uxCanvas.Size = New System.Drawing.Size(880, 536)
        Me.uxCanvas.TabIndex = 0
        Me.uxCanvas.TabStop = False
        '
        'uxStatusBar
        '
        Me.uxStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxCursorPositionLabel})
        Me.uxStatusBar.Location = New System.Drawing.Point(0, 514)
        Me.uxStatusBar.Name = "uxStatusBar"
        Me.uxStatusBar.Size = New System.Drawing.Size(880, 22)
        Me.uxStatusBar.TabIndex = 1
        Me.uxStatusBar.Text = "StatusStrip1"
        '
        'uxCursorPositionLabel
        '
        Me.uxCursorPositionLabel.Name = "uxCursorPositionLabel"
        Me.uxCursorPositionLabel.Size = New System.Drawing.Size(33, 17)
        Me.uxCursorPositionLabel.Text = "(0,0)"
        '
        'uxMenuBar
        '
        Me.uxMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFile, Me.uxMenuEdit, Me.uxMenuView})
        Me.uxMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.uxMenuBar.Name = "uxMenuBar"
        Me.uxMenuBar.Size = New System.Drawing.Size(880, 25)
        Me.uxMenuBar.TabIndex = 2
        Me.uxMenuBar.Text = "MenuStrip1"
        '
        'uxMenuFile
        '
        Me.uxMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFileNew, Me.uxMenuFileOpen, Me.uxMenuFileClose, Me.ToolStripSeparator1, Me.uxMenuFileExport})
        Me.uxMenuFile.Name = "uxMenuFile"
        Me.uxMenuFile.Size = New System.Drawing.Size(39, 21)
        Me.uxMenuFile.Text = "File"
        '
        'uxMenuFileNew
        '
        Me.uxMenuFileNew.Name = "uxMenuFileNew"
        Me.uxMenuFileNew.Size = New System.Drawing.Size(131, 22)
        Me.uxMenuFileNew.Text = "New"
        '
        'uxMenuFileOpen
        '
        Me.uxMenuFileOpen.Name = "uxMenuFileOpen"
        Me.uxMenuFileOpen.Size = New System.Drawing.Size(131, 22)
        Me.uxMenuFileOpen.Text = "Open"
        '
        'uxMenuFileClose
        '
        Me.uxMenuFileClose.Name = "uxMenuFileClose"
        Me.uxMenuFileClose.Size = New System.Drawing.Size(131, 22)
        Me.uxMenuFileClose.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'uxMenuFileExport
        '
        Me.uxMenuFileExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFileExportPdf, Me.uxMenuFileExportJpg, Me.uxMenuFileExportPng})
        Me.uxMenuFileExport.Name = "uxMenuFileExport"
        Me.uxMenuFileExport.Size = New System.Drawing.Size(131, 22)
        Me.uxMenuFileExport.Text = "Export as"
        '
        'uxMenuFileExportPdf
        '
        Me.uxMenuFileExportPdf.Name = "uxMenuFileExportPdf"
        Me.uxMenuFileExportPdf.Size = New System.Drawing.Size(107, 22)
        Me.uxMenuFileExportPdf.Text = "*.pdf"
        '
        'uxMenuFileExportJpg
        '
        Me.uxMenuFileExportJpg.Name = "uxMenuFileExportJpg"
        Me.uxMenuFileExportJpg.Size = New System.Drawing.Size(107, 22)
        Me.uxMenuFileExportJpg.Text = "*.jpg"
        '
        'uxMenuFileExportPng
        '
        Me.uxMenuFileExportPng.Name = "uxMenuFileExportPng"
        Me.uxMenuFileExportPng.Size = New System.Drawing.Size(107, 22)
        Me.uxMenuFileExportPng.Text = "*.png"
        '
        'uxMenuEdit
        '
        Me.uxMenuEdit.Name = "uxMenuEdit"
        Me.uxMenuEdit.Size = New System.Drawing.Size(42, 21)
        Me.uxMenuEdit.Text = "Edit"
        '
        'uxMenuView
        '
        Me.uxMenuView.Name = "uxMenuView"
        Me.uxMenuView.Size = New System.Drawing.Size(47, 21)
        Me.uxMenuView.Text = "View"
        '
        'uxMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.uxStatusBar)
        Me.Controls.Add(Me.uxMenuBar)
        Me.Controls.Add(Me.uxCanvas)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.uxMenuBar
        Me.Name = "uxMainForm"
        Me.Text = "P&ID(raw)"
        CType(Me.uxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uxStatusBar.ResumeLayout(False)
        Me.uxStatusBar.PerformLayout()
        Me.uxMenuBar.ResumeLayout(False)
        Me.uxMenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uxCanvas As PictureBox
    Friend WithEvents uxStatusBar As StatusStrip
    Friend WithEvents uxCursorPositionLabel As ToolStripStatusLabel
    Friend WithEvents uxMenuBar As MenuStrip
    Friend WithEvents uxMenuFile As ToolStripMenuItem
    Friend WithEvents uxMenuFileNew As ToolStripMenuItem
    Friend WithEvents uxMenuFileOpen As ToolStripMenuItem
    Friend WithEvents uxMenuFileClose As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents uxMenuFileExport As ToolStripMenuItem
    Friend WithEvents uxMenuFileExportPdf As ToolStripMenuItem
    Friend WithEvents uxMenuFileExportJpg As ToolStripMenuItem
    Friend WithEvents uxMenuFileExportPng As ToolStripMenuItem
    Friend WithEvents uxMenuEdit As ToolStripMenuItem
    Friend WithEvents uxMenuView As ToolStripMenuItem
    Friend WithEvents uxCycleTimer As Timer
End Class
