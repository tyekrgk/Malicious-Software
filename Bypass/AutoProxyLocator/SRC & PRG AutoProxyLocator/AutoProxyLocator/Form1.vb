Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://free-proxy-list.net/"), HttpWebRequest)
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim input As String = New StreamReader(response.GetResponseStream).ReadToEnd
        Dim matchs As MatchCollection = New Regex("<tr><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td><td>.*</td></tr>").Matches(input)
        Me.proxyData.BeginUpdate()
        Dim num As Integer = 0
        Dim index As Integer = 0
        Do While (num <= matchs.Count)
            Dim enumerator As IEnumerator
            Try
                enumerator = matchs.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As Match = DirectCast(enumerator.Current, Match)
                    Dim itemArray As ListViewItem() = New ListViewItem((index + 1) - 1) {}
                    Dim text As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(2)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str15 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(4)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str5 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(6)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str7 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(8)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str3 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(10)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str9 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(12)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str11 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(14)), "td>", "", 1, -1, CompareMethod.Binary)
                    Dim str13 As String = Strings.Replace(Conversions.ToString(current.Value.Split(New Char() {"<"c}).GetValue(&H10)), "td>", "", 1, -1, CompareMethod.Binary)
                    itemArray(index) = Me.proxyData.Items.Add([text])
                    itemArray(index).SubItems.Add(str15)
                    itemArray(index).SubItems.Add(str5)
                    itemArray(index).SubItems.Add(str7)
                    itemArray(index).SubItems.Add(str3)
                    itemArray(index).SubItems.Add(str9)
                    itemArray(index).SubItems.Add(str11)
                    itemArray(index).SubItems.Add(str13)
                    num += 1
                    index += 1
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Loop
        Me.proxyData.Refresh()
        Me.proxyData.EndUpdate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim enumerator As IEnumerator
        Dim path As String = "APL_Exported_Proxies.txt"
        Dim writer As New StreamWriter(path)
        Try
            enumerator = Me.proxyData.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                writer.WriteLine((current.Text & ":" & current.SubItems.Item(1).Text))
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        MessageBox.Show("Proxies successfully exported to APL_Exported_Proxies.txt.", "AutoProxy Locator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        writer.Close()
    End Sub

    Private Sub proxyData_DoubleClick(sender As Object, e As EventArgs) Handles proxyData.DoubleClick
        Clipboard.SetText((Me.proxyData.SelectedItems.Item(0).Text & ":" & Me.proxyData.SelectedItems.Item(0).SubItems.Item(1).Text))
        MessageBox.Show("Address copied to clipboard!", "AutoProxy Locator", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
