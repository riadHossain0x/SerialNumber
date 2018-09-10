Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Public Class frmmain
    Private Function SerialNumber() As String
        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", Nothing))
        Dim text As String = ""
        Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "InstancesOf", New Object() {"Win32_BaseBoard"}, Nothing, Nothing, Nothing))
        Try
            Dim enumerator As IEnumerator = CType(objectValue2, IEnumerable).GetEnumerator()
            While enumerator.MoveNext()
                Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
                text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(", ", NewLateBinding.LateGet(objectValue3, Nothing, "SerialNumber", New Object(-1) {}, Nothing, Nothing, Nothing))))
            End While
        Catch ex As Exception

        End Try
        Dim flag As Boolean = text.Length > 0
        If flag Then
            text = text.Substring(2)
        End If
        Return text
    End Function

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = SerialNumber()
    End Sub
End Class
