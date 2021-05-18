Imports System.ComponentModel
Imports NAudio.CoreAudioApi

Public Class Form1
    Private WithEvents MySettings As My.MySettings = My.Settings

    Private Sub MySettings_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles MySettings.PropertyChanged
        MySettings.Save()
    End Sub

    Dim maxPeak As Double = 0F
    Dim slowPeak As Double = 0F
    Dim snddeviceenum As New MMDeviceEnumerator
    Dim snddevice As MMDevice = snddeviceenum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)

    Dim endpoints As New List(Of MMDevice)

    Public Shared currPeak As Integer
    Public Shared alertSound As String
    Public Shared customSoundPath As String

    Public Shared override As Boolean = False

    Dim alertThread As New Threading.Thread(AddressOf alert)



    Private Sub PlayAlert(sound As String, Optional playmode As AudioPlayMode = AudioPlayMode.WaitToComplete)
        Select Case sound
            Case "custom"
                My.Computer.Audio.Play(customSoundPath, playmode)
            Case "Aaah"
                My.Computer.Audio.Play(My.Resources.Aaah, playmode)
            Case "ChimePlingeling"
                My.Computer.Audio.Play(My.Resources.ChimePlingeling, playmode)
            Case "DiDing"
                My.Computer.Audio.Play(My.Resources.DiDing, playmode)
            Case "Ding"
                My.Computer.Audio.Play(My.Resources.Ding, playmode)
            Case "DingDing"
                My.Computer.Audio.Play(My.Resources.DingDing, playmode)
            Case "Failor"
                My.Computer.Audio.Play(My.Resources.Failor, playmode)
            Case "MarioAufWishBestellt"
                My.Computer.Audio.Play(My.Resources.MarioAufWishBestellt, playmode)
            Case "Notification"
                My.Computer.Audio.Play(My.Resources.Notification, playmode)
            Case "Pflong"
                My.Computer.Audio.Play(My.Resources.Pflong, playmode)
            Case "Sonar"
                My.Computer.Audio.Play(My.Resources.Sonar, playmode)
            Case "Success"
                My.Computer.Audio.Play(My.Resources.Success, playmode)
            Case "Success2"
                My.Computer.Audio.Play(My.Resources.Success2, playmode)
            Case "Öouuh"
                My.Computer.Audio.Play(My.Resources.OEouuh, playmode)
            Case "Uuuh"
                My.Computer.Audio.Play(My.Resources.Uuuh, playmode)
            Case "UuuhMyGawd"
                My.Computer.Audio.Play(My.Resources.UuuhMyGawd, playmode)
            Case "Wew"
                My.Computer.Audio.Play(My.Resources.Wew, playmode)
        End Select
    End Sub

    Sub alert()
        While True
            If currPeak > maxPeak Then maxPeak = currPeak

            If currPeak >= NumericUpDownAlertThreshold.Value And CheckBoxAlertGroup.Checked Then

                If CheckBoxAlertAcoustic.Checked Then
                    PlayAlert(alertSound, AudioPlayMode.Background)
                End If

                Threading.Thread.Sleep(NumericUpDownAlertPostDelay.Value)
            End If

            Threading.Thread.Sleep(10)
        End While
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IndicatorMaxPeak.Size = New Point(1, 14)
        IndicatorCurrentPeak.Size = New Point(1, 18)
        IndicatorSlowPeak.Size = New Point(1, 16)
        IndicatorThreshold.Size = New Point(2, 20)

        ComboBoxAcousticAlert.Text = alertSound
        IndicatorThreshold.Location = New Point((Label1.Width / 100) * NumericUpDownAlertThreshold.Value + 7, 44)

        For Each ep As MMDevice In snddeviceenum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)
            endpoints.Add(ep)
            If ep.ID = snddevice.ID Then
                ComboBoxAudioDevice.Items.Add("🔈 " + ep.FriendlyName + " *                                                                                     " + ep.ID)
            Else
                ComboBoxAudioDevice.Items.Add("🔈 " + ep.FriendlyName + "                                                                                     " + ep.ID)
            End If
        Next

        For Each ep As MMDevice In snddeviceenum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)
            endpoints.Add(ep)
            If ep.ID = snddeviceenum.GetDefaultAudioEndpoint(DataFlow.Capture, DeviceState.Active).ID Then
                ComboBoxAudioDevice.Items.Add("🎤 " + ep.FriendlyName + " *                                                                                     " + ep.ID)
            Else
                ComboBoxAudioDevice.Items.Add("🎤 " + ep.FriendlyName + "                                                                                      " + ep.ID)
            End If
        Next

        'AudioDevice.SelectedItem = "* " + snddevice.FriendlyName + "                                                                                     " + snddevice.Id

        ComboBoxAudioDevice.Text = "🔈 " + snddevice.FriendlyName + " *                                                                                     " + snddevice.ID
        ComboBoxAcousticAlert.Text = "DingDing"


        alertThread.IsBackground = True
        alertThread.Start()

    End Sub

    Private Sub AudioDevice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAudioDevice.SelectedIndexChanged
        Dim sel As String
        sel = ComboBoxAudioDevice.Text.Substring(ComboBoxAudioDevice.Text.IndexOf("{"))

        snddevice = snddeviceenum.GetDevice(sel)
        maxPeak = 0
        Label4.Focus()
    End Sub

    Private Sub CBAcoustic_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAlertAcoustic.CheckedChanged
        Select Case CheckBoxAlertAcoustic.Checked
            Case True
                ComboBoxAcousticAlert.Enabled = True
            Case False
                ComboBoxAcousticAlert.Enabled = False
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        currPeak = snddevice.AudioMeterInformation.MasterPeakValue * 100
        If currPeak > maxPeak Then maxPeak = currPeak
        Label2.Text = currPeak.ToString
        Label5.Text = slowPeak.ToString
        Label6.Text = maxPeak.ToString

        Indicator(IndicatorCurrentPeak, currPeak)
    End Sub

    Private Sub CBBAlert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAcousticAlert.SelectedIndexChanged
        If ComboBoxAcousticAlert.Text = "Select file.." Then
            Using fd As New OpenFileDialog
                With fd
                    .Filter = "wav audio file|*.wav"
                    .Title = "Select audio alert"
                    .Multiselect = False
                    If .ShowDialog = DialogResult.OK Then
                        customSoundPath = .FileName
                        alertSound = "custom"
                    Else
                        ComboBoxAcousticAlert.Text = alertSound
                    End If
                End With
            End Using
        Else
            alertSound = ComboBoxAcousticAlert.Text
        End If
        PlayAlert(alertSound, AudioPlayMode.Background)
    End Sub

    Sub Indicator(pnl As Panel, peak As Double)
        Dim nw = New Point((((Label1.Width - 10) / 100) * peak) + 11, 44)

        If Not pnl.AccessibleDescription = IndicatorMaxPeak.AccessibleDescription Then
            If nw.X > pnl.Location.X Then
                If (nw.X - pnl.Location.X) < 3 Then Exit Sub
            Else
                If (nw.X - pnl.Location.X) > 3 Then Exit Sub
            End If
        End If

        pnl.Location = nw
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        slowPeak = currPeak
        Indicator(IndicatorSlowPeak, currPeak)
        Indicator(IndicatorMaxPeak, maxPeak)
    End Sub

#Region "Tooltips"
    Private Sub Label2_Hover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        ToolTip1.ToolTipTitle = "Current peak"
        ToolTip1.Show("Current volume peak", Label2)
    End Sub

    Private Sub Label5_Hover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        ToolTip1.ToolTipTitle = "Slowed peak"
        ToolTip1.Show("Current peak but slower refresh rate.", Label5)
    End Sub

    Private Sub Label6_Hover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        ToolTip1.ToolTipTitle = "Max peak"
        ToolTip1.Show("Max. reached peak", Label6)
    End Sub
#End Region

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAlertGroup.CheckedChanged
        If CheckBoxAlertGroup.Checked Then
            GroupBoxAlert.Enabled = True
        Else
            GroupBoxAlert.Enabled = False
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim n = ((MousePosition.X - Location.X) - 14) / (Label1.Width / 100)
        If n > 100 Then n = 100
        If n < 1 Then n = 1
        NumericUpDownAlertThreshold.Value = n
        IndicatorThreshold.Location = New Point((Label1.Width / 100) * NumericUpDownAlertThreshold.Value + 7, 44)
    End Sub

    Private Sub IndicatorMaxPeak_Click(sender As Object, e As EventArgs) Handles IndicatorMaxPeak.Click
        Label1_Click(IndicatorMaxPeak, EventArgs.Empty)
    End Sub

    Private Sub IndicatorSlowPeak_Click(sender As Object, e As EventArgs) Handles IndicatorSlowPeak.Click
        Label1_Click(IndicatorMaxPeak, EventArgs.Empty)
    End Sub

    Private Sub IndicatorCurrentPeak_Click(sender As Object, e As EventArgs) Handles IndicatorCurrentPeak.Click
        Label1_Click(IndicatorMaxPeak, EventArgs.Empty)
    End Sub

    Private Sub IndicatorThreshold_Click(sender As Object, e As EventArgs) Handles IndicatorThreshold.Click
        Label1_Click(IndicatorMaxPeak, EventArgs.Empty)
    End Sub

    Private Sub NumericUpDownAlertThreshold_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownAlertThreshold.ValueChanged
        IndicatorThreshold.Location = New Point((Label1.Width / 100) * NumericUpDownAlertThreshold.Value + 7, 44)
    End Sub
End Class
