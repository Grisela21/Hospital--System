Imports System.Globalization
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient


Module ModuleScheduling


    Private cn As New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")

    Public Sub Connect()
            If cn.State = ConnectionState.Closed Then cn.Open()
        End Sub

    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New SqlCommand(sql, cn)

        Return cmd.ExecuteNonQuery() > 0
    End Function

    Public Function IsConfirm(ByVal message As String) As Boolean
            Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
        End Function

        Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New SqlDataAdapter(sql, cn)
        Dim ds As New DataSet
            da.Fill(ds, "result")
            Return ds.Tables("result")
        End Function

        Public Function ConvertDateToString(ByVal dateVal As Date) As String
            Return dateVal.ToString("MM/dd/yyyy", CultureInfo.GetCultureInfo("en-US"))
        End Function

    End Module






