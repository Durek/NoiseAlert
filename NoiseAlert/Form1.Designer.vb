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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBoxAudioDevice = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownAlertThreshold = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxAcousticAlert = New System.Windows.Forms.ComboBox()
        Me.GroupBoxAlert = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownAlertPostDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxAlertAcoustic = New System.Windows.Forms.CheckBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxAlertGroup = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IndicatorMaxPeak = New System.Windows.Forms.Panel()
        Me.IndicatorSlowPeak = New System.Windows.Forms.Panel()
        Me.IndicatorCurrentPeak = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IndicatorThreshold = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NumericUpDownAlertThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlert.SuspendLayout()
        CType(Me.NumericUpDownAlertPostDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxAudioDevice
        '
        Me.ComboBoxAudioDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ComboBoxAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxAudioDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ComboBoxAudioDevice.FormattingEnabled = True
        Me.ComboBoxAudioDevice.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxAudioDevice.Name = "ComboBoxAudioDevice"
        Me.ComboBoxAudioDevice.Size = New System.Drawing.Size(193, 21)
        Me.ComboBoxAudioDevice.TabIndex = 999
        '
        'NumericUpDownAlertThreshold
        '
        Me.NumericUpDownAlertThreshold.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.NumericUpDownAlertThreshold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.NumericUpDownAlertThreshold.Location = New System.Drawing.Point(80, 19)
        Me.NumericUpDownAlertThreshold.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownAlertThreshold.Name = "NumericUpDownAlertThreshold"
        Me.NumericUpDownAlertThreshold.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDownAlertThreshold.TabIndex = 4
        Me.NumericUpDownAlertThreshold.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Threshold"
        '
        'ComboBoxAcousticAlert
        '
        Me.ComboBoxAcousticAlert.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ComboBoxAcousticAlert.DisplayMember = "DingDing"
        Me.ComboBoxAcousticAlert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAcousticAlert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxAcousticAlert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ComboBoxAcousticAlert.Items.AddRange(New Object() {"Aaah", "ChimePlingeling", "DiDing", "Ding", "DingDing", "Failor", "MarioAufWishBestellt", "Notification", "Pflong", "Sonar", "Success", "Success2", "Öouuh", "Uuuh", "UuuhMyGawd", "Wew", "Select file.."})
        Me.ComboBoxAcousticAlert.Location = New System.Drawing.Point(80, 71)
        Me.ComboBoxAcousticAlert.Name = "ComboBoxAcousticAlert"
        Me.ComboBoxAcousticAlert.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxAcousticAlert.TabIndex = 8
        '
        'GroupBoxAlert
        '
        Me.GroupBoxAlert.Controls.Add(Me.NumericUpDownAlertPostDelay)
        Me.GroupBoxAlert.Controls.Add(Me.Label4)
        Me.GroupBoxAlert.Controls.Add(Me.Label3)
        Me.GroupBoxAlert.Controls.Add(Me.ComboBoxAcousticAlert)
        Me.GroupBoxAlert.Controls.Add(Me.CheckBoxAlertAcoustic)
        Me.GroupBoxAlert.Controls.Add(Me.NumericUpDownAlertThreshold)
        Me.GroupBoxAlert.Location = New System.Drawing.Point(12, 80)
        Me.GroupBoxAlert.Name = "GroupBoxAlert"
        Me.GroupBoxAlert.Size = New System.Drawing.Size(193, 104)
        Me.GroupBoxAlert.TabIndex = 9
        Me.GroupBoxAlert.TabStop = False
        '
        'NumericUpDownAlertPostDelay
        '
        Me.NumericUpDownAlertPostDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.NumericUpDownAlertPostDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.NumericUpDownAlertPostDelay.Location = New System.Drawing.Point(80, 45)
        Me.NumericUpDownAlertPostDelay.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownAlertPostDelay.Name = "NumericUpDownAlertPostDelay"
        Me.NumericUpDownAlertPostDelay.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDownAlertPostDelay.TabIndex = 10
        Me.NumericUpDownAlertPostDelay.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Post delay"
        '
        'CheckBoxAlertAcoustic
        '
        Me.CheckBoxAlertAcoustic.AutoSize = True
        Me.CheckBoxAlertAcoustic.Checked = True
        Me.CheckBoxAlertAcoustic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAlertAcoustic.Location = New System.Drawing.Point(8, 73)
        Me.CheckBoxAlertAcoustic.Name = "CheckBoxAlertAcoustic"
        Me.CheckBoxAlertAcoustic.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxAlertAcoustic.TabIndex = 0
        Me.CheckBoxAlertAcoustic.Text = "Acoustic"
        Me.CheckBoxAlertAcoustic.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 50
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'CheckBoxAlertGroup
        '
        Me.CheckBoxAlertGroup.AutoSize = True
        Me.CheckBoxAlertGroup.Checked = True
        Me.CheckBoxAlertGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAlertGroup.Location = New System.Drawing.Point(45, 79)
        Me.CheckBoxAlertGroup.Name = "CheckBoxAlertGroup"
        Me.CheckBoxAlertGroup.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxAlertGroup.TabIndex = 11
        Me.CheckBoxAlertGroup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 1001
        Me.Label1.Text = "I I I I I I I I I I I I I I I I I I I I I I I I I I I I I I I I I"
        '
        'IndicatorMaxPeak
        '
        Me.IndicatorMaxPeak.AccessibleDescription = "t9324"
        Me.IndicatorMaxPeak.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IndicatorMaxPeak.Location = New System.Drawing.Point(33, 45)
        Me.IndicatorMaxPeak.Name = "IndicatorMaxPeak"
        Me.IndicatorMaxPeak.Size = New System.Drawing.Size(32, 16)
        Me.IndicatorMaxPeak.TabIndex = 1002
        '
        'IndicatorSlowPeak
        '
        Me.IndicatorSlowPeak.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.IndicatorSlowPeak.Location = New System.Drawing.Point(71, 44)
        Me.IndicatorSlowPeak.Name = "IndicatorSlowPeak"
        Me.IndicatorSlowPeak.Size = New System.Drawing.Size(32, 16)
        Me.IndicatorSlowPeak.TabIndex = 1002
        '
        'IndicatorCurrentPeak
        '
        Me.IndicatorCurrentPeak.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.IndicatorCurrentPeak.Location = New System.Drawing.Point(109, 44)
        Me.IndicatorCurrentPeak.Name = "IndicatorCurrentPeak"
        Me.IndicatorCurrentPeak.Size = New System.Drawing.Size(32, 16)
        Me.IndicatorCurrentPeak.TabIndex = 1002
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = "slowed"
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(100, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = "max"
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(189, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 1003
        Me.Label7.Text = "Alert"
        '
        'IndicatorThreshold
        '
        Me.IndicatorThreshold.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.IndicatorThreshold.Location = New System.Drawing.Point(147, 44)
        Me.IndicatorThreshold.Name = "IndicatorThreshold"
        Me.IndicatorThreshold.Size = New System.Drawing.Size(32, 16)
        Me.IndicatorThreshold.TabIndex = 1002
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "test"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(217, 195)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IndicatorThreshold)
        Me.Controls.Add(Me.IndicatorCurrentPeak)
        Me.Controls.Add(Me.IndicatorSlowPeak)
        Me.Controls.Add(Me.IndicatorMaxPeak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxAlertGroup)
        Me.Controls.Add(Me.GroupBoxAlert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxAudioDevice)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "NoiseAlert"
        CType(Me.NumericUpDownAlertThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlert.ResumeLayout(False)
        Me.GroupBoxAlert.PerformLayout()
        CType(Me.NumericUpDownAlertPostDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxAudioDevice As ComboBox
    Friend WithEvents NumericUpDownAlertThreshold As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxAcousticAlert As ComboBox
    Friend WithEvents GroupBoxAlert As GroupBox
    Friend WithEvents CheckBoxAlertAcoustic As CheckBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NumericUpDownAlertPostDelay As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBoxAlertGroup As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IndicatorMaxPeak As Panel
    Friend WithEvents IndicatorSlowPeak As Panel
    Friend WithEvents IndicatorCurrentPeak As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents IndicatorThreshold As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
